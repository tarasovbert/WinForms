using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneShop
{
    public partial class PhoneShop_MainForm : Form
    {
        List<CellPhone> Phones;
        string[] phonesInfo;
        string optionName;
        DialogResult result;
        List<string> PhoneOptions = new List<string> { "Wi-Fi", "3G", "Bluetooth", "GPS", "Camera" };//basic set of options in any good phone :)

        public PhoneShop_MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Phones = new List<CellPhone>// basic set of cellphones we are starting to trade
            {
                new CellPhone("Apple iPhone 5s 16GB Space Gray", "iOS", 2.3, 599.99m,
                    @"PhonesPictures\Apple iPhone 5s 16GB Space Gray.jpg", new List<string> { "3G", "Bluetooth", "GPS", "Camera" }),
                new CellPhone("Huawei P8lite 2017 Black", "Android", 3.0, 411.56m,
                    @"PhonesPictures\HuaweiP8lite2017Black.jpeg", new List<string> { "Wi-Fi", "Bluetooth", "GPS", "Camera" }),
                new CellPhone("MEIZU M3 Note 16GB Gray", "Android", 1.8, 250.19m,
                    @"PhonesPictures\MEIZU_M3_Note_16GB_Gray.jpg", new List<string> { "Wi-Fi", "3G", "GPS", "Camera" }),
                new CellPhone("Samsung Galaxy S7 Edge 32GB BlackOnyx", "Android", 4.2, 800.25m,
                    @"PhonesPictures\SamsungGalaxyS7Edge32GBBlackOnyx.jpg", new List<string> { "Wi-Fi", "3G", "Bluetooth", "Camera" }),
                new CellPhone("Xiaomi Redmi4 16GB Gray", "Android", 2.6, 351.30m,
                   @"PhonesPictures\XiaomiRedmi4_16GBGray.jpeg", new List<string> { "Wi-Fi", "3G", "Bluetooth", "GPS"})
             };
            RefreshListAndInfo();
            SerializePhones();
            SerializeOptions();
        }

        #region BUTTON_METHODS
        private void button_AddOption_Click(object sender, EventArgs e)
        {
            if (PhoneOptions.Contains(textBox_OptionName.Text))
            {
                result = MessageBox.Show("Such option is already in list!", "Error!");
                textBox_OptionName.Text = String.Empty;
            }
            else if (textBox_OptionName.Text.Length != 0)
            {
                PhoneOptions.Add(textBox_OptionName.Text);
                RefreshListAndInfo();
            }
        }

        private void button_AddPhone_Click(object sender, EventArgs e)
        {
            double newCPU;
            decimal newPrice;
            while (!Double.TryParse(String.Format(textBox_CPUEdit.Text), out newCPU))
            {
                result = MessageBox.Show("Enter a number of GHz to 'CPU' field!", "Error!");
                textBox_CPUEdit.Text = 0.ToString();
            }
            while (!Decimal.TryParse(String.Format(textBox_PriceEdit.Text), out newPrice))
            {
                result = MessageBox.Show("Enter a price of the cellphone to 'Price' field!", "Error!");
                textBox_PriceEdit.Text = 0.ToString();
            }
            Phones.Add(new CellPhone()
            {
                Model = textBox_ModelEdit.Text,
                OS = textBox_OSEdit.Text,
                CPU = newCPU,
                Price = newPrice,
                Picture = textBox_PictureEdit.Text,
                Options = new List<string> { "Wi-Fi", "3G", "Bluetooth", "GPS", "Camera" }
            });
            listBox_PhonesList.DataSource = null;
            listBox_PhonesList.DataSource = Phones;
        }


        private void button_ClearList_Click(object sender, EventArgs e)
        {
            Phones.Clear();
            listBox_PhonesList.DataSource = null;

            RefreshListAndInfo();
        }

        private void button_ClearFields_Click(object sender, EventArgs e)
        {
            ClearEditFields();
        }

        private void button_DeleteCurrent_Click(object sender, EventArgs e)
        {
            Phones.Remove(Phones[listBox_PhonesList.SelectedIndex]);
            RefreshListAndInfo();
        }

        private void button_ReadFromFile_Click(object sender, EventArgs e)
        {
            DeserializePhones();
            RefreshListAndInfo();
        }

        private void button_RemoveOption_Click(object sender, EventArgs e)
        {
            if (PhoneOptions.Count > 0)
            {
                PhoneOptions.RemoveAt(checkedListBox_EditOptions.SelectedIndex);
                RefreshListAndInfo();
            }
            else
            {
                result = MessageBox.Show("There's no option to remove!", "Error!");
            }
        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            if (Phones.Count > 0)
            {
                Phones[listBox_PhonesList.SelectedIndex].Model = textBox_ModelEdit.Text;

                Phones[listBox_PhonesList.SelectedIndex].OS = textBox_OSEdit.Text;

                double newCPU = Phones[listBox_PhonesList.SelectedIndex].CPU;
                while (!Double.TryParse(String.Format(textBox_CPUEdit.Text), out newCPU))
                {
                    result = MessageBox.Show("Enter a number of GHz to 'CPU' field!", "Error!");
                    textBox_CPUEdit.Text = String.Format($"{Phones[listBox_PhonesList.SelectedIndex].CPU}");
                }
                Phones[listBox_PhonesList.SelectedIndex].CPU = newCPU;

                decimal newPrice = Phones[listBox_PhonesList.SelectedIndex].Price;
                while (!Decimal.TryParse(String.Format(textBox_PriceEdit.Text), out newPrice))
                {
                    result = MessageBox.Show("Enter a price of the cellphone to 'Price' field!", "Error!");
                    textBox_PriceEdit.Text = String.Format($"{Phones[listBox_PhonesList.SelectedIndex].Price}");
                }
                Phones[listBox_PhonesList.SelectedIndex].Price = newPrice;

                Phones[listBox_PhonesList.SelectedIndex].Picture = textBox_PictureEdit.Text;
              
                SerializePhones();
                RefreshListAndInfo();
            }
        }

        private void button_SaveToFile_Click(object sender, EventArgs e)
        {
            SerializePhones();
        }
        #endregion

        #region OTHER_METHODS
        private void checkedListBox_EditOptions_Click(object sender, EventArgs e)
        {
            optionName = (string)checkedListBox_EditOptions.SelectedItem;
            if (!Phones[listBox_PhonesList.SelectedIndex].Options.Contains(optionName))
            {
                if (!checkedListBox_EditOptions.GetItemChecked(checkedListBox_EditOptions.SelectedIndex))
                    Phones[listBox_PhonesList.SelectedIndex].Options.Add(optionName);
            }

            else if (Phones[listBox_PhonesList.SelectedIndex].Options.Contains(optionName))
                if (checkedListBox_EditOptions.GetItemChecked(checkedListBox_EditOptions.SelectedIndex))
                    Phones[listBox_PhonesList.SelectedIndex].Options.Remove(optionName);
            listBox_Options.DataSource = null;
            listBox_Options.DataSource = Phones[listBox_PhonesList.SelectedIndex].Options;
        }

        private void ClearEditFields()
        {
            textBox_ModelEdit.Text = null;
            textBox_OSEdit.Text = null;
            textBox_CPUEdit.Text = null;
            textBox_PriceEdit.Text = null;
            textBox_PictureEdit.Text = null;
        }

        private void DeserializePhones()
        {
            using (FileStream phonesFile = new FileStream("phonesFile.bin", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                Phones = (List<CellPhone>)binFormat.Deserialize(phonesFile);
            }
        }

        private void listBox_PhonesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_PhonesList.SelectedItem != null)
            {
                ListBox PhonesList = (ListBox)sender;
                listBox_Options.DataSource = null;
                listBox_Options.DataSource = Phones[listBox_PhonesList.SelectedIndex].Options;
                pictureBox_CellphoneImage.ImageLocation = Phones[PhonesList.SelectedIndex].Picture;
                textBox_Model.Text = Phones[PhonesList.SelectedIndex].Model;
                textBox_OS.Text = Phones[PhonesList.SelectedIndex].OS;
                textBox_CPU.Text = String.Format($"{ Phones[PhonesList.SelectedIndex].CPU}");
                textBox_Price.Text = String.Format("{0:c}", Phones[PhonesList.SelectedIndex].Price);
                textBox_ModelEdit.Text = Phones[PhonesList.SelectedIndex].Model;
                textBox_OSEdit.Text = Phones[PhonesList.SelectedIndex].OS;
                textBox_CPUEdit.Text = String.Format($"{ Phones[PhonesList.SelectedIndex].CPU}");
                textBox_PriceEdit.Text = String.Format("{0}", Phones[PhonesList.SelectedIndex].Price);
                textBox_PictureEdit.Text = pictureBox_CellphoneImage.ImageLocation;
                RefreshCheckListBox_EditOptions();
            }
            else
                pictureBox_CellphoneImage.ImageLocation = @"PhonesPictures\DefaultPhone.jpg";
        }

        private void MakeListOfPhones()
        {
            phonesInfo = new string[Phones.Count];
            for (int i = 0; i < phonesInfo.Length; i++)
            {
                phonesInfo[i] = Phones[i].ToString();
            }
        }       

        private void RefreshCheckListBox_EditOptions()
        {
            checkedListBox_EditOptions.DataSource = null;
            checkedListBox_EditOptions.DataSource = PhoneOptions;
            for (int i = 0; i < PhoneOptions.Count; i++)
            {
                if (Phones[listBox_PhonesList.SelectedIndex].Options.Contains(PhoneOptions[i]))
                    checkedListBox_EditOptions.SetItemChecked(i, true);
                else checkedListBox_EditOptions.SetItemChecked(i, false);
            }
        }

        private void RefreshListAndInfo()
        {
            if (Phones.Count > 0)
            {
                MakeListOfPhones();
                listBox_PhonesList.DataSource = null;
                listBox_PhonesList.DataSource = phonesInfo;
                RefreshCheckListBox_EditOptions();
            }
            else
            {
                listBox_Options.DataSource = null;
                pictureBox_CellphoneImage.ImageLocation = @"PhonesPictures\DefaultPhone.jpg";
                textBox_Model.Text = null;
                textBox_OS.Text = null;
                textBox_CPU.Text = null;
                textBox_Price.Text = null;
                ClearEditFields();
            }
        }

        private void SerializeOptions()
        {
            using (FileStream optionsFile = new FileStream("optionsFile.bin", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(optionsFile, PhoneOptions);
            }
        }

        private void SerializePhones()
        {
            using (FileStream phonesFile = new FileStream("phonesFile.bin", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(phonesFile, Phones);
            }
        }
        #endregion
    }
}