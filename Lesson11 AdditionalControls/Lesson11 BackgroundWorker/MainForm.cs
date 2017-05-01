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

namespace Lesson11_BackgroundWorker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bgwMain.DoWork += BgwMain_DoWork;
            bgwMain.RunWorkerCompleted += BgwMain_RunWorkerCompleted;
            bgwMain.WorkerReportsProgress = true;
            bgwMain.ProgressChanged += BgwMain_ProgressChanged;
            bgwMain.WorkerSupportsCancellation = true;
        }

        private void BgwMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lb_Status.Text = String.Format("{0}%", e.ProgressPercentage);
            pb_Process.Value = e.ProgressPercentage;
        }

        private void BgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                lb_Status.Text = "Cancelled!";
            else
                lb_Status.Text = "Completed! " + e.Result.ToString();

        }

        private void BgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = (int)e.Argument; // the argument passed by  bgwMain.RunWorkerAsync(...);
            for (int i = 0; i <= count; i++)
            {
                if (bgwMain.CancellationPending == true)
                {
                    bgwMain.ReportProgress(0);
                    e.Cancel = true;
                    break;
                }
                bgwMain.ReportProgress(i * 100 / count);
                Thread.Sleep(300);
            }
            e.Result = "Work is done!";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(!bgwMain.IsBusy)
            bgwMain.RunWorkerAsync(10);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            bgwMain.CancelAsync();
        }
    }
}
