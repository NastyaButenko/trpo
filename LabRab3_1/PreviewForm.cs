using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRab3_1
{
    public partial class PreviewForm : Form
    {
        private Bitmap memoryImage; //буфер для хранения изображения
        public PreviewForm(string name, string surname, string section, string filename)
        {
            InitializeComponent();
            label1.Text = name.ToUpper();
            label2.Text = surname.ToUpper();
            label3.Text = section.ToUpper();
            pictureBox1.Load(filename);
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.ClientSize;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen(); //получение изображения формы
            printDocument1.Print(); //печать документа
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
