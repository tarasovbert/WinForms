using System;
using System.Windows.Forms;

namespace CarFile.Forms
{
    public partial class AddImporterOrCountryForm : Form
    {
        public string TextToAdd { get; set; }

        public AddImporterOrCountryForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tb_ImporterOrCountry.Text))
            {
                TextToAdd = tb_ImporterOrCountry.Text;
                Close();
            }
        }
    }
}
