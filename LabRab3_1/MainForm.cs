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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //если введен символ вне диапазона от «А» до «я»
            //или клавиша не является клавишей Backspace
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8))
                e.Handled = true; //предотвращаем обработку символа

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; //установка 1го значения из списка как выбранного
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //если в диалоге выбора пользователь нажал на кнопку OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName); //загружаем изображение в компонент
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие текущей формы
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //если все поля и имя файла изображения не являются пустыми значениями
            if ((textBox1.Text != "") && (textBox1.Text != "") && (openFileDialog1.FileName != ""))
            {
                //создаем форму предварительного просмотра
                PreviewForm previewFrm = new PreviewForm(textBox1.Text, textBox2.Text, comboBox1.Text, openFileDialog1.FileName);
                //показываем эту форму в диалоговом режиме
                previewFrm.ShowDialog();
            }
        }
    }
}
