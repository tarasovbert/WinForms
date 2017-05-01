using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestGasStation
{
    public partial class GasStation : Form
    {
        List<Fuel> fuelSorts;
        public double FuelPrice { get; private set; }
        public double FuelPayment { get; private set; }
        private double fuelQuantity;
        private StringBuilder dutySB;
        private string dutyStr;
        private char dutyChar;
        private bool fraction;
        public GasStation()
        {
            InitializeComponent();
            dutySB = new StringBuilder();
        }

        private void checkBoxes_Click(object sender, EventArgs e)
        {
            CheckBox chB = (CheckBox)sender;
            TextBox tB = (TextBox)this.Controls[chB.Tag.ToString()];
            tB.Enabled = chB.Checked;
        }


        private void GasStation_Load_1(object sender, EventArgs e)
        {
            fuelSorts = new List<Fuel>()
            { new Fuel() { Name = "A-92", Price = 1.14},
            new Fuel() { Name = "A-95", Price = 1.22},
            new Fuel() { Name = "Diesel", Price = 1.26},
            new Fuel() { Name = "Gas", Price = 0.67}};
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = fuelSorts;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            ComboBox cB1 = (ComboBox)sender;
            //if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex < fuelSorts.Count)
            if (comboBox1.SelectedIndex > -1)
            {
                textBox1.Text = fuelSorts[comboBox1.SelectedIndex].Price.ToString();
                FuelPrice = fuelSorts[comboBox1.SelectedIndex].Price;
            }
        }

        private void radioButton1_2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                RadioButton rB1 = (RadioButton)sender;
                TextBox tB2 = (TextBox)this.groupBox2.Controls[rB1.Tag.ToString()];
                if (tB2 != null)
                {
                    tB2.Enabled = rB1.Checked;
                    tB2.ReadOnly = false;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tB2 = (TextBox)sender;
            if (tB2.Text.Length > 0)
                dutyChar = tB2.Text[tB2.Text.Length - 1];
            if (dutyChar == '.') dutyChar = ',';
            if (dutyChar == ',') fraction = true;
            if (Char.IsDigit(dutyChar) || dutyChar == ',')
            {
                if ((dutyChar == ',' && fraction == false) || dutyChar != ',')
                    dutySB.Append(dutyChar);
                if (dutySB[dutySB.Length - 1] != ',') fuelQuantity = Double.Parse(dutySB.ToString());
                gasPayTextBox.Text = (fuelQuantity * FuelPrice).ToString();
            }
            //TextBox tB2 = (TextBox)sender;
            //if (tB2.Text.Length > 0)
            //    dutyChar = tB2.Text[tB2.Text.Length - 1];
            //if (dutyChar == '.') dutyChar = ',';
            //if (dutyChar == ',') fraction = true;
            //if (Char.IsDigit(dutyChar) || dutyChar == ',')
            //{
            //    if ((dutyChar == ',' && fraction == false) || dutyChar != ',')
            //        dutyStr += dutyChar;
            //    if (dutyStr[dutyStr.Length - 1] != ',') fuelQuantity = Double.Parse(dutyStr);
            //    textBox4.Text = (fuelQuantity * FuelPrice).ToString();
            //}
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox2.Text = "";
        //    gasPayTextBox.Text = "";
        //    dutySB.Clear();
        //}

        private void clearButton_Click(object sender, EventArgs e)
        {
            Button clearButton = (Button)sender;
            TextBox clearTB =  (TextBox)groupBox2.Controls[clearButton.Tag.ToString()];
            clearTB.Text = "";
            gasPayTextBox.Text = "";
            dutySB.Clear();
        }
    }
}
