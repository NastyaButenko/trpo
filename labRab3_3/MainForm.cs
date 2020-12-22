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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Books.books[0, 0] = "Портрет Дориана Грея";
            Books.books[1, 0] = "Оскар Уайльд";
            Books.books[2, 0] = "Роман";
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
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllBooks allBooks = new AllBooks();
            allBooks.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Find1 find1 = new Find1();
            find1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Find2 find2 = new Find2();
            find2.ShowDialog();
        }
    }
}
