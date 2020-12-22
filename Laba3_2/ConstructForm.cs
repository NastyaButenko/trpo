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
    public partial class ConstructForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private int indexOfFlat; //индекс переносимого пункта из списка Плитка
        private bool flat = false; //флаг переноса изображения плитки

        private int indexOfDecor; //индекс переносимого пункта из списка Декор
        private int sizeOfDecor = 50; //размер изображения декора
                                      //список размещенных элементов декора
        private List<PictureBox> decors = new List<PictureBox>();
        public ConstructForm()
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

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            flat = true; //устанавливаем флаг переноса плитки
                         // Получаем индекс выбранного элемента
            indexOfFlat = listView1.Items.IndexOf(listView1.GetItemAt(e.X, e.Y));
            if (indexOfFlat != -1) //если удалось определить индекс
            {
                //начинаем операцию перетаскивания элемента
                listView1.DoDragDrop(listView1.Items[indexOfFlat].ImageIndex,
                DragDropEffects.Copy);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; //устанавливаем режим перетаскивания
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (flat) //если выбрана операция перетаскивания изображения плитки
            {
                //устанавливаем в качестве фонового изображения панели перетаскиваемое из списка
                panel1.BackgroundImage = imgListFlat.Images[indexOfFlat];
            }
            else //если выбрана операция перетаскивания изображения декора
            {
                decors.Add(new PictureBox()); //добавляем в список новый элемент декора
                                              //помещаем новый компонент в панель
                panel1.Controls.Add(decors[decors.Count - 1]);
                //устанавливаем размер компонента
                decors[decors.Count - 1].Width = decors[decors.Count - 1].Height = sizeOfDecor;
                //устанавливаем изображение элемента
                decors[decors.Count - 1].Image = imgListDecor.Images[indexOfDecor];
                //подписываем компонент на событие отпускания клавиши мыши
                decors[decors.Count - 1].MouseUp +=
                new MouseEventHandler(this.pictureBox_MouseUp);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            //если была нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                //создаем копию перетаскиваемого объекта
                PictureBox img = sender as PictureBox;
                //изменяем его положение на панели
                if (MouseIsOverControl(panel1))//проверка положения курсора
                {
                    img.Left = img.Left + e.X - img.Width / 2;
                    img.Top = img.Top + e.Y - img.Height / 2;
                }
            }
            //ПКМ удаление
            else if(e.Button == MouseButtons.Right)
            {
                panel1.Controls.Remove((sender as PictureBox));
            }
        }
        private bool MouseIsOverControl(Panel panel) => panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position));

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            flat = false; //сбрасываем флаг переноса плитки
                          //определяем индекс выбранного в списке элемента
            indexOfDecor = listView2.Items.IndexOf(listView2.GetItemAt(e.X, e.Y));
            //если удалось определить индекс
            if (indexOfDecor != -1)
            {
                //начинаем операцию перетаскивания элемента
                listView2.DoDragDrop(listView2.Items[indexOfDecor].ImageIndex,
                DragDropEffects.Copy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            panel1.Controls.Clear();
            decors.Clear();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
