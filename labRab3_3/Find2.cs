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
    public partial class Find2 : Form
    {
        public Find2()
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

        private void Find2_Load(object sender, EventArgs e)
        {
            List<string> booksList = new List<string>();
            for (int i = 0; i < Books.rows; i++)
                if (Books.books[0, i] == null || Books.books[0, i] == "")
                    break;
                else
                    comboBox1.Items.Add(Books.books[2, i]);

            object[] distinctItems = (from object o in comboBox1.Items select o).Distinct().ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(distinctItems);

            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            RefreshList();
        }

        void RefreshList()
        {
            this.listBox1.Visible = true;
            List<string> booksList = new List<string>();
            for (int i = 0; i < Books.rows; i++)
                if (Books.books[0, i] == null || Books.books[0, i] == "")
                    break;
                else if (Books.books[2, i].Contains(comboBox1.Text))
                    booksList.Add("Название: " + Books.books[0, i] + "\tАвтор: " + Books.books[1, i] + "\tЖанр: " + Books.books[2, i]);
            this.listBox1.DataSource = booksList;
            label2.Text = "Количество книг: " + listBox1.Items.Count;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
