using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib.Controls;

namespace Turandot_Editor.Controls.Screen
{
    public partial class CheckBoxList : KUserControl
    {
        private string _listName = "List";
        private List<CheckBox> _boxes = new List<CheckBox>();

        public CheckBoxList()
        {
            InitializeComponent();
            _boxes.Add(checkBox1);
        }

        public string ListName
        {
            get { return _listName; }
            set
            {
                _listName = value;
                groupBox.Text = value;
            }
        }

        public void SetItems(List<string> items)
        {
            for (int k = 0; k < items.Count; k++)
            {
                if (k > 0)
                {
                    AddRow();
                }
                _boxes[k].Text = items[k];
            }
            Refresh();
        }

        public void CheckItems(List<string> items)
        {
            foreach (var cb in _boxes)
            {
                cb.Checked = items.Contains(cb.Text.ToLower());
            }
        }

        private CheckBox AddRow()
        {
            int newRowNum = _boxes.Count;

            CheckBox c = new CheckBox();
            c.AutoSize = true;
            c.Name = "checkBox" + (newRowNum + 1);
            c.CheckedChanged += checkBox_CheckedChanged;
            c.Height = _boxes[0].Height;
            c.Location = new Point(_boxes[0].Location.X, _boxes[newRowNum-1].Location.Y + _boxes[0].Height + 5);
            
            _boxes.Add(c);
            groupBox.Controls.Add(c);

            return c;
        }

        public event EventHandler<CheckedItem> ItemCheckedChanged;
        private void OnItemCheckedChanged(CheckedItem item)
        {
            if (ItemCheckedChanged != null) ItemCheckedChanged(this, item);
        }
        public class CheckedItem : EventArgs
        {
            public string name;
            public bool isChecked;
            public CheckedItem(string name, bool isChecked)
            {
                this.name = name;
                this.isChecked = isChecked;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            OnItemCheckedChanged(new CheckedItem(cb.Text, cb.Checked));
        }
    }
}
