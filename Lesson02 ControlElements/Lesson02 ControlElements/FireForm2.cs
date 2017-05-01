using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.iconfinder.com/

namespace Lesson02_ControlElements
{

    public partial class FireForm2 : Form
    {
        List<SubjectInfo> subjects;
        public FireForm2()
        {
            InitializeComponent();
        }

        private void FireForm2_Load(object sender, EventArgs e)
        {
            subjects = new List<SubjectInfo>
            {
                new SubjectInfo() {Name = "C#", DaysCount = 150 },
                new SubjectInfo() {Name = "WinForms", DaysCount = 100 },
                new SubjectInfo() {Name = "WPF", DaysCount = 80 },
                new SubjectInfo() {Name = "ADO.Net", DaysCount = 120 },
                new SubjectInfo() {Name = "ASP.Net", DaysCount = 190 } };
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = subjects;
            comboBox1.SelectedIndex = -1; // noone to being diplayed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox2.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                this.Text += "Clicked!";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem != null)
            if (comboBox1.SelectedItem != null)
            {
                SubjectInfo dis = (SubjectInfo)comboBox1.SelectedItem;
                this.Text = dis.DaysCount.ToString();
            }
            else
            {
                this.Text = String.Empty;
            }
        }
    }
}
