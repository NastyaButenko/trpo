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
    public partial class AllBooks : Form
    {
        public AllBooks()
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

        private void AllBooks_Load(object sender, EventArgs e)
        {
            List<string> booksList = new List<string>();
            for (int i = 0; i < Books.rows; i++)
                if (Books.books[0, i] == null || Books.books[0, i] == "")
                    break;
            else
                booksList.Add("Название: " + Books.books[0, i] + "\tАвтор: " + Books.books[1, i] + "\tЖанр: " + Books.books[2, i]);
            this.listBox1.DataSource = booksList;
        }
    }
}
