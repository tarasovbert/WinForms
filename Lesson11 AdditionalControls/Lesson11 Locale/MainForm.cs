using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson11_Locale
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.Size;
            this.Location = Properties.Settings.Default.Position;

            string lngName = Properties.Settings.Default.Language;
            if (!String.IsNullOrEmpty(lngName))
            {
                Thread.CurrentThread.CurrentCulture =
                    new System.Globalization.CultureInfo(lngName);

                Thread.CurrentThread.CurrentUICulture =
                    new System.Globalization.CultureInfo(lngName);

            }
            LoadCulture();
        }

        private void LoadCulture()
        {
            cb_Cultures.DataSource = new List<System.Globalization.CultureInfo>()
            {
                new System.Globalization.CultureInfo("ru-Ru"),
                new System.Globalization.CultureInfo("en"),
                new System.Globalization.CultureInfo("fr-Fr"),
                new System.Globalization.CultureInfo("de-De")            
            };
            cb_Cultures.DisplayMember = "NativeName";
           // cb_Cultures.ValueMember = "Name";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Size = this.Size;
            Properties.Settings.Default.Position = this.Location;

            string lngName = Thread.CurrentThread.CurrentCulture.Name;
            Properties.Settings.Default.Language = lngName;
            Properties.Settings.Default.Save();
        }

        private void cb_Cultures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Cultures.SelectedItem != null)
            {           

                Thread.CurrentThread.CurrentCulture = 
                    (System.Globalization.CultureInfo)cb_Cultures.SelectedItem;
                Thread.CurrentThread.CurrentUICulture =
                   (System.Globalization.CultureInfo)cb_Cultures.SelectedItem;

                var selCultureInfo = (System.Globalization.CultureInfo)cb_Cultures.SelectedItem;

                ComponentResourceManager res = new ComponentResourceManager(typeof(MainForm));
                res.ApplyResources(btn_Show, "Text", selCultureInfo);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.MessageResourses.ErrorMessage);
        }
    }
}
