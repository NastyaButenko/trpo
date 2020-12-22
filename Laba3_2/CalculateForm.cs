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
    public partial class CalculateForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private static short n = 4; //количество значений
        private short[,] tileSize = new short[n, 2]; //список возможных размеров плитки
        private short[] tileCount = new short[n]; //список для выбора кол-ва плитки

        public CalculateForm()
        {
            InitializeComponent();

            //заполнение списка "размер плитки" (ширина и высота)
            tileSize[0, 0] = 10; tileSize[0, 1] = 10;

            tileSize[1, 0] = 15; tileSize[1, 1] = 15;

            tileSize[2, 0] = 10; tileSize[2, 1] = 15;

            tileSize[3, 0] = 20; tileSize[3, 1] = 20;

            //заполение списка "количество"
            tileCount[0] = 8;
            tileCount[1] = 10;
            tileCount[2] = 12;
            tileCount[3] = 20;

            for (int i = 0; i < n; i++) //заполняем список "размеры плитки"
                comboBox1.Items.Add(String.Format("{0}x{1}", tileSize[i, 0], tileSize[i, 1]));
            for (int i = 0; i < n; i++) //заполняем список "количество"
                comboBox2.Items.Add(String.Format("{0}", tileCount[i]));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')) e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.Ceiling(
                ((Convert.ToDouble(textBox1.Text) * 
                Convert.ToDouble(textBox2.Text))/
                (Convert.ToDouble(comboBox1.SelectedItem.ToString().Split('x')[0])*
                Convert.ToDouble(comboBox1.SelectedItem.ToString().Split('x')[1])))/Convert.ToDouble(comboBox2.SelectedItem.ToString())
                ).ToString();
        }

        private void CalculateForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void CalculateForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void CalculateForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
