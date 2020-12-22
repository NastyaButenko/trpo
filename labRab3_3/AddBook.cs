using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labRab3_3
{
    public partial class AddBook : Form
    {
        public AddBook()
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

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Books.rows; i++)
            {
                if(Books.books[0, i] == null || Books.books[0,i] == "")
                {
                    Books.books[0, i] = textBox1.Text;
                    Books.books[1, i] = textBox2.Text;
                    Books.books[2, i] = textBox3.Text;
                    MessageBox.Show("Успешно!");
                    break;
                }
            }
        }
    }
}
