using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson03_ListElements
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            string[] arr = { "C#", "WPF", "WinForms", "ADO.NET"};
            for (int i = 0; i < arr.Length; i++)
          //  { listBox1.Items.Add(arr[i]); }
            listBox1.DataSource = arr;
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                if(!listBox2.Items.Contains(listBox1.SelectedItems[i]))
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
                i--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
                i--;
            }
        }
    }
}
