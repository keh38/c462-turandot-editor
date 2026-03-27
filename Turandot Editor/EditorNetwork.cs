using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib.IO;
using KLib.Net;
using Newtonsoft.Json;

namespace Turandot_Editor
{

    [JsonObject]
    public class HtsEndpointPayload
    {
        public string Address { get; set; }
        public int Port { get; set; }
    }

    public class EditorNetwork
    {
        public delegate void RemoteMessageHandlerDelegate(TcpMessage message);
        public RemoteMessageHandlerDelegate RemoteMessageHandler { set; get; } = null;

        private IPEndPoint _ipEndPoint;
        private IPEndPoint _htsEndPoint = null;

        private CancellationTokenSource _serverCancellationToken;

        public EditorNetwork() { }

        public void Disconnect()
        {
            if (_ipEndPoint != null)
            {
                _serverCancellationToken.Cancel();
            }
        }

        public void StartListener()
        {
            _ipEndPoint = new IPEndPoint(IPAddress.Loopback, 40002);

            _serverCancellationToken = new CancellationTokenSource();
            Task.Run(() =>
            {
                Listener(_ipEndPoint, _serverCancellationToken.Token);
            }, _serverCancellationToken.Token);
        }

        public void SendMessageToHTS(string message, object payloadObject=null)
        {
            if (_htsEndPoint == null) return;

            var response = KTcpClient.SendRequest(_htsEndPoint, TcpMessage.Request("GetCurrentSceneName"));
            if (!response.IsOk) return;

            string currentSceneName = response.GetPayload<string>();
            if (currentSceneName != "Turandot")
            {
                response = KTcpClient.SendRequest(_htsEndPoint, TcpMessage.Request("ChangeScene", (object)"Turandot"));
                if (!response.IsOk) return;
            }

            if (payloadObject != null)
            {
                KTcpClient.SendRequest(_htsEndPoint, new TcpMessage() { Command = message, Payload = JsonConvert.SerializeObject(payloadObject) });
            }
            else
            {
                KTcpClient.SendRequest(_htsEndPoint, new TcpMessage() { Command = message, Payload = "{}" });
            }
        }

        private void Listener(IPEndPoint endpoint, CancellationToken ct)
        {
            var server = new KTcpListener();
             server.StartListener(endpoint);

            Debug.WriteLine($"TCP server started on {endpoint}");

            while (!ct.IsCancellationRequested)
            {
                try
                {
                    if (server.Pending())
                    {
                        ProcessTCPMessage(server);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            server.CloseListener();
            Debug.WriteLine("TCP server stopped");
        }

        private void ProcessTCPMessage(KTcpListener server)
        {
            server.AcceptTcpClient();
            var request = server.ReadRequest();
            server.WriteResponse(TcpMessage.Ok());

            Debug.WriteLine($"Received message: {request.Command}");

            switch (request.Command)
            {
                case "Ping":
                    break;
                case "SetHtsEndpoint":
                    var ep = request.GetPayload<HtsEndpointPayload>();
                    _htsEndPoint = !string.IsNullOrEmpty(ep.Address)
                        ? new IPEndPoint(IPAddress.Parse(ep.Address), ep.Port)
                        : null;
                    break;
                default:
                    RemoteMessageHandler?.Invoke(request);
                    break;
            }

            server.CloseTcpClient();

        }

    }
}
