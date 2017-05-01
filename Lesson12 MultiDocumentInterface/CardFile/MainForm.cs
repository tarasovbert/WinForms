using System;
using System.ComponentModel;
using System.Windows.Forms;
using CarFile.Classes;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CarFile.Forms;

namespace CarFile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }

        private void mi_CarsList_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void tbtn_CarsList_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void ShowList()
        {
            CarsListForm form = new CarsListForm();
            form.MdiParent = this;
            form.lb_listOfCars.DataSource = Data.Cars;
            form.Show();
        }       

        private void mi_AddCar_Click(object sender, EventArgs e)
        {
            AddCar();
        }

        private void tbtn_AddCar_Click(object sender, EventArgs e)
        {
            AddCar();
        }
        private void AddCar()
        {
            AddCarForm form = new AddCarForm();
            form.MdiParent = this;
            form.cb_Country.DataSource = Data.CountriesOfOrigin;
            form.cb_Importer.DataSource = Data.Importers;
            form.Show();
        }

        private void mi_AddCountry_Click(object sender, EventArgs e)
        {
            AddCountry();
        }

        private void tbtn_AddCountry_Click(object sender, EventArgs e)
        {
            AddCountry();
        }

        private static void AddCountry()
        {
            AddImporterOrCountryForm form = new AddImporterOrCountryForm();
            form.ShowDialog();
            if (!Data.CountriesOfOrigin.Contains(form.TextToAdd))
                Data.CountriesOfOrigin.Add(form.TextToAdd);
        }

        private void mi_AddImporter_Click(object sender, EventArgs e)
        {
            AddImporter();
        }

        private void tbtn_AddImporter_Click(object sender, EventArgs e)
        {
            AddImporter();
        }

        private static void AddImporter()
        {
            AddImporterOrCountryForm form = new AddImporterOrCountryForm();
            form.ShowDialog();
            if (!Data.Importers.Contains(form.TextToAdd))
                Data.Importers.Add(form.TextToAdd);
        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void tbtn_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            SaveFileDialog CarsSFDialog = new SaveFileDialog();
            CarsSFDialog.RestoreDirectory = true;
            CarsSFDialog.Filter = "Binary files (*.bin)|*.bin";
            CarsSFDialog.FileName = "cars";
            CarsSFDialog.Title = "Choose the destination file to save your list of cars";
            if (CarsSFDialog.ShowDialog() == DialogResult.OK)
                using (FileStream fsCars = new FileStream("cars.bin", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    binFormatter.Serialize(fsCars, Data.Cars);

                    SaveFileDialog CountriesSFDialog = new SaveFileDialog();
                    CountriesSFDialog.RestoreDirectory = true;
                    CountriesSFDialog.Filter = "Binary files (*.bin)|*.bin";
                    CountriesSFDialog.FileName = "countries";
                    CountriesSFDialog.Title = "Choose the destination file to save your list of countries of origin";
                    if (CountriesSFDialog.ShowDialog() == DialogResult.OK)
                        using (FileStream fsCountries = new FileStream("countries.bin", FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            binFormatter.Serialize(fsCountries, Data.CountriesOfOrigin);

                            SaveFileDialog ImportersSFDialog = new SaveFileDialog();
                            ImportersSFDialog.RestoreDirectory = true;
                            ImportersSFDialog.Filter = "Binary files (*.bin)|*.bin";
                            ImportersSFDialog.FileName = "importers";
                            ImportersSFDialog.Title = "Choose the destination file to save your list of importers";
                            if (ImportersSFDialog.ShowDialog() == DialogResult.OK)
                                using (FileStream fsImporters = new FileStream("importers.bin", FileMode.OpenOrCreate, FileAccess.Write))
                                {
                                    binFormatter.Serialize(fsImporters, Data.Importers);
                                }
                        }
                }
        }

        private void tbtn_Load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void loadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            OpenFileDialog CarsOFDialog = new OpenFileDialog();
            CarsOFDialog.RestoreDirectory = true;
            CarsOFDialog.Filter = "Binary files (*.bin)|*.bin";
            CarsOFDialog.FileName = "cars";
            CarsOFDialog.Title = "Choose the source file to load your list of cars";
            if (CarsOFDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fsCars = new FileStream(CarsOFDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    Data.Cars = (BindingList<Car>)binFormatter.Deserialize(fsCars);

                    OpenFileDialog CountriesOFDialog = new OpenFileDialog();
                    CountriesOFDialog.RestoreDirectory = true;
                    CountriesOFDialog.Filter = "Binary files (*.bin)|*.bin";
                    CountriesOFDialog.FileName = "countries";
                    CountriesOFDialog.Title = "Choose the source file to load your list of countries of origin";
                    if (CountriesOFDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fsCountries = new FileStream(CountriesOFDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            Data.CountriesOfOrigin = (BindingList<string>)binFormatter.Deserialize(fsCountries);

                            OpenFileDialog ImportersOFDialog = new OpenFileDialog();
                            ImportersOFDialog.RestoreDirectory = true;
                            ImportersOFDialog.Filter = "Binary files (*.bin)|*.bin";
                            ImportersOFDialog.FileName = "importers";
                            ImportersOFDialog.Title = "Choose the source file to load your list of countries of origin";
                            if (ImportersOFDialog.ShowDialog() == DialogResult.OK)
                            {
                                using (FileStream fsImporters = new FileStream(ImportersOFDialog.FileName, FileMode.Open, FileAccess.Read))
                                {
                                    Data.Importers = (BindingList<string>)binFormatter.Deserialize(fsImporters);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}