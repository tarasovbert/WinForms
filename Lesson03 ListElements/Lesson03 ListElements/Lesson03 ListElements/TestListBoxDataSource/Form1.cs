using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListBoxDataSource
{
    public partial class MainForm : Form
    {
        BindingList<Car> cars;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cars = new BindingList<Car>()
            {   new Car() { Name = "Volvo", Price = 40000 },
                new Car() { Name = "BMW", Price = 30000 },
                new Car() { Name = "Mercedes", Price = 350000 }};
            listBox1.DataSource = cars;
            checkedListBox1.DataSource = cars;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Name = textBox1.Text;
            car.Price = numericUpDown1.Value;
            cars.Add(car);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(listBox1.SelectedItem != null)
            //{
            //    Car selCar = listBox1.SelectedItem as Car;
            //    cars.Remove(selCar);
            //}

            //for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            //{
            //    Car selCar = (Car)listBox1.SelectedItems[i];
            //    cars.Remove(selCar);
            //    i--;
            //}

            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                Car selCar = (Car)listBox1.SelectedItems[i];
                cars.Remove(selCar);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Car selCar = listBox1.SelectedItem as Car;
                textBox1.Text = selCar.Name;
                numericUpDown1.Value = selCar.Price;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car selCar = listBox1.SelectedItem as Car;
            selCar.Name =  textBox1.Text;
            selCar.Price = numericUpDown1.Value;
            listBox1.DataSource = null; // cause BindingList doesn't look for properties (Name, Price)
            listBox1.DataSource = cars;
        }

        
    }
}
