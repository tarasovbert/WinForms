using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson13_GDI_GraphicsDeviceInterface_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(10, 10, 150, 120);
            path.AddEllipse(170, 10, 150, 120);

            Region rgn = new Region(path);
            this.Region = rgn;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics grh = this.CreateGraphics();
            SolidBrush solidBrush = new SolidBrush(Color.LightGreen);
            Image img = new Bitmap("pic.jpg");
            TextureBrush textureBrush = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Tile);
            grh.FillEllipse(textureBrush, 50, 50, 400, 300);

            HatchBrush hatchbrush = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.RosyBrown);
            grh.FillPie(hatchbrush, 500, 100, 400, 400, 0, 90);

            LinearGradientBrush gradBrush = new LinearGradientBrush
                (new Point(10, 10), new Point(270, 270), Color.Red, Color.Green);
            grh.FillPie(gradBrush, 10, 10, 250, 250, 0, 360);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("pic.jpg");
            Graphics grh = Graphics.FromImage(bmp);
            grh.DrawIcon(SystemIcons.Error, 50, 50);
            Graphics grhForm = this.CreateGraphics();
            grhForm.DrawImage(bmp, new Rectangle(150, 50, 350, 300));
            bmp.Save("newPic.jpg");
        }

        //private void MainForm_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics grh =  e.Graphics;
        //    Pen pen = new Pen(Color.Red, 3f);

        //    grh.DrawLine(pen, new Point(50, 50), new Point(250, 50));
        //    grh.DrawRectangle(pen, 50, 100, 150, 150);
        //    grh.DrawEllipse(pen, 50, 100, 150, 150);
        //    grh.DrawPie(new Pen(Color.DarkSlateBlue, 2), 50, 100, 150, 150, 0, 90);

        //    grh.DrawPolygon(new Pen(Color.DarkOrchid, 4),
        //        new Point[] { new Point(250, 100), new Point(350, 200), new Point(300, 250), new Point(400, 300), new Point(550, 300) });

        //    grh.DrawIcon(SystemIcons.Question, 110, 160);

        //    SolidBrush brush = new SolidBrush(Color.LightGreen);
        //    grh.FillPie(brush, 50, 100, 150, 150, 0, 90);
        //}
    }
}
