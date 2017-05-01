using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF2
{


    public partial class MainForm : Form
    {

        List<SubjectInfo> subs;

        public MainForm()
        {
            //textBox1.Text = "C##";
            InitializeComponent();
            textBox1.Text = "C##";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            subs = new List<SubjectInfo>()
            {
                new SubjectInfo() { Name="C#", DaysCount=24},
                new SubjectInfo() { Name="WinForms", DaysCount=20 },
                new SubjectInfo() { Name="WPF", DaysCount=16},
                new SubjectInfo() { Name="ADO.NET", DaysCount=16},
            };

            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = subs;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedIndex!=-1)
            if (comboBox1.SelectedItem != null)
            {
                SubjectInfo selSub = (SubjectInfo)comboBox1.SelectedItem;
                this.Text = selSub.DaysCount.ToString();
            }
            else
            {
                this.Text = String.Empty;
            }
        }
    }
}
