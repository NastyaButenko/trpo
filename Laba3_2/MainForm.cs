using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3_2
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateForm calculateForm = new CalculateForm();
            calculateForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstructForm constructForm = new ConstructForm();
            constructForm.ShowDialog();
        }

        private void pnlBorder_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.Copy);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
