using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib;
using KLib.Net;

namespace Turandot_Editor
{
    public class EditorNetwork
    {
        public delegate void RemoteMessageHandlerDelegate (string message);
        public RemoteMessageHandlerDelegate RemoteMessageHandler { set; get; } = null;

        private IPEndPoint _ipEndPoint;
        private int _serverPort = 4951;
        private bool _lastPingSucceeded = false;

        private CancellationTokenSource _serverCancellationToken;

        public bool IsConnected { get { return _ipEndPoint != null && _lastPingSucceeded; } }

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
            _ipEndPoint = Discovery.FindNextAvailableEndPoint();

            _serverCancellationToken = new CancellationTokenSource();
            Task.Run(() =>
            {
                Listener(_ipEndPoint, _serverCancellationToken.Token);
            }, _serverCancellationToken.Token);

            Task.Run(() =>
            {
                MulticastReceiver("TURANDOT.EDITOR", _ipEndPoint, _serverCancellationToken.Token);
            }, _serverCancellationToken.Token);
        }

        private void Listener(IPEndPoint endpoint, CancellationToken ct)
        {
            var server = new KTcpListener();
             server.StartListener(endpoint);

            Debug.WriteLine($"TCP server started on {server.ListeningOn}");

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

            string input = server.ReadString();
            server.SendAcknowledgement();
            server.CloseTcpClient();

            RemoteMessageHandler?.Invoke(input);
        }


        private void MulticastReceiver(string name, IPEndPoint endpoint, CancellationToken ct)
        {
            var ipLocal = new IPEndPoint(endpoint.Address, 10000);
            Debug.WriteLine(ipLocal);

            var address = IPAddress.Parse("234.5.6.7");
            var ipEndPoint = new IPEndPoint(address, 10000);

            var udp = new UdpClient();
            udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udp.Client.Bind(ipLocal);
            udp.Client.ReceiveTimeout = 1000;

            udp.JoinMulticastGroup(address, endpoint.Address);
            Debug.WriteLine(endpoint.Address);

            var anyIP = new IPEndPoint(IPAddress.Any, 0);

            while (!ct.IsCancellationRequested)
            {
                try
                {
                    // receive bytes
                    var bytes = udp.Receive(ref anyIP);
                    var response = Encoding.Default.GetString(bytes);

                    if (response.Equals(name))
                    {
                        bytes = Encoding.UTF8.GetBytes(endpoint.Port.ToString());
                        udp.Send(bytes, bytes.Length, anyIP);
                    }
                }
                catch (Exception ex)
                {
                    //Debug.WriteLine(ex.Message);
                }
            }
        }

    }
}
