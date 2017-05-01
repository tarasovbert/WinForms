using CarFile.Classes;
using System;
using System.Windows.Forms;

namespace CarFile.Forms
{
    public partial class AddCarForm : Form
    {
       
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void btn_AddCountry_Click(object sender, EventArgs e)
        {
            AddImporterOrCountryForm form = new AddImporterOrCountryForm();
            form.ShowDialog();
            if (!Data.CountriesOfOrigin.Contains(form.TextToAdd))
                Data.CountriesOfOrigin.Add(form.TextToAdd);
        }

        private void btn_AddImporter_Click(object sender, EventArgs e)
        {
            AddImporterOrCountryForm form = new AddImporterOrCountryForm();
            form.ShowDialog();
            if (!Data.Importers.Contains(form.TextToAdd))
                Data.Importers.Add(form.TextToAdd);
        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            int mass;                               
            string imp = cb_Importer.Text;
            if (Int32.TryParse(tb_mass.Text, out mass))
            {
                if (!String.IsNullOrWhiteSpace(tb_Mark.Text) && !String.IsNullOrWhiteSpace(tb_mass.Text)
                    && !String.IsNullOrWhiteSpace(cb_Country.Text)
                    && !String.IsNullOrWhiteSpace(cb_Importer.Text))
                {
                    Data.Cars.Add(new Car(Data.Cars.Count + 1, tb_Mark.Text, cb_Country.SelectedItem.ToString(), mass, cb_Importer.SelectedItem.ToString()));
                    Close();
                }
                else if (String.IsNullOrWhiteSpace(tb_Mark.Text) && String.IsNullOrWhiteSpace(tb_mass.Text))
                    MessageBox.Show("Please enter a mark and a mass of the car to proceed!");
                else if (String.IsNullOrWhiteSpace(tb_Mark.Text))
                    MessageBox.Show("Please enter a mark of the car to proceed!");
                else if (String.IsNullOrWhiteSpace(cb_Country.Text))
                    MessageBox.Show("Please enter a country of origin!");
                else MessageBox.Show("Please enter an importer!");
            }
            else MessageBox.Show("A mass should be an integer!");
        }        
    }
}
