using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Elements
{
    public partial class Form1 : Form
    {
        TreeView tree;//объявляем вне формы, для того чтобы можно было использовать в других функциях //tree - дерево("меню")//создали
        Button btn;//создали кнопку
        Label lbl;
        PictureBox ptb;
        public Form1()
        {
            //this - форма
            this.Height = 500;//свойство высота формы
            this.Width = 800;//свойство ширины формы, если это свойство то после, ставится =
            this.Text = "Vorm elementiga";//Text - название, заголовок формы
            this.BackColor = Color.Bisque;//фон для формы
            tree = new TreeView();
            tree.Dock = DockStyle.Left;//местоположение -  Left-слева
            tree.AfterSelect += Tree_AfterSelect;//Tree_AfterSelect - это (1)
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));//new - добавить//добавили кнопку в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Silt-Label"));//добавили Label в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("PictureBox"));//добавили PictureBox в меню(дерево-меню)

            tn.Nodes.Add(new TreeNode("Märkeruut-Checkbox"));//добавили Checkbox в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));//добавили радиокнопку в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Tekstkast-TextBox"));//добавили текстбокс в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));//добавили Kaart в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("MessageBox"));//добавили MessageBox в меню(дерево-меню)


            //Создаём кнопку(свойста его - местоположение, высота, ширина)
            btn = new Button();
            btn.BackColor = Color.Coral;//фон кнопки
            btn.Text = "Vajuta siia";//текст внутри кнопки
            btn.Location = new Point(150, 30);//Point(x,y) - местоположение кнопки
            btn.Height = 40;//высота кнопки
            btn.Width = 100;//ширина кнопки
            btn.Click += Btn_Click;//создаёт функцию если нажать на кнопку (tab)

            //pealkiri
            lbl = new Label();// создали Label
            lbl.Text = "Elamentide loomine c# abil";
            lbl.Size = new Size(600, 30);//Size(width,height)
            lbl.Location = new Point(150, 0); //Point(x,y) - местоположение Label
            lbl.MouseHover += Lbl_MouseHover;//мышка будет наведена на Label
            lbl.MouseHover += Lbl_MouseHover1;//мышка будет наведена на Label

            //PictureBox
            ptb = new PictureBox();//создали PictureBox
            //ptb.Image = new Bitmap("horosho.jpg");
            ptb.Size = new Size(400, 300);
            ptb.Location = new Point(200, 100);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;


            //ptb.Image = Image.FromFile(@"..\..\image\horosho.jpg");

            ptb.ImageLocation = ("../../image/horosho.jpg");
            //ptb.ImageLocation=("../propetries/horosho.jpg");


            //Double_Click -> carusel (3-4 images) 1-2-3-4-1-2-3-4-....
            //ptb.Image = image.img1;




            ptb.DoubleClick += Ptb_DoubleClick;

            tree.Nodes.Add(tn);//связались
            this.Controls.Add(tree);//добавляет в форму
        }


        int scetcikkartinok = 0;
        private void Ptb_DoubleClick(object sender, EventArgs e)
        {
            //string[] img = ("bob.gif", "google.gif", "Lennuk.jpg", "priroda.jpg");
            //ptb.ImageLocation = ("../../image/samolet.jpg");
            scetcikkartinok++; //тут я увеличиваю значения счетчика на 1
            if (scetcikkartinok == 1)
            {
                
                ptb.ImageLocation = ("../../image/hello.gif");

            }
            else if (scetcikkartinok == 2)
            {

                ptb.ImageLocation = ("../../image/samolet.jpg");
            }
            else if (scetcikkartinok == 3)
            {
                ptb.ImageLocation = ("../../image/kvadratcernej.jpeg");
            }
            else if (scetcikkartinok == 4)
            {

                scetcikkartinok = 0; //сбрасывает счетччик, что бы начать все заново
                ptb.ImageLocation = ("../../image/horosho.jpg");
            }

        }

        private void Lbl_MouseHover1(object sender, EventArgs e)
        {
            //var rand = new Random();
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(82, 212, 199);//меняет фон label
        }

        private void Btn_Click(object sender, EventArgs e)//функция если будет нажата кнопка
        {

            btn.Text = "Tere tulemast!";
            this.BackColor = Color.LightYellow;
            ptb.ImageLocation = ("../../image/samolet.jpg");

        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)//(1) вот это
        {
            if (e.Node.Text == "Nupp")//если будет нажата nupp(в меню)
            {
                this.Controls.Add(btn);//добавляет кнопку в форму
            }
            else if (e.Node.Text == "Silt-Label")//если будет нажата Silt-Label(в меню)
            {
                this.Controls.Add(lbl);//добавляет Label в форму
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(ptb);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            /*int count = 0;
            count++; //тут я увеличиваю значения счетчика на 1
            if (count == 1)
            {

                ptb.ImageLocation = ("../../image/hello.gif");

            }
            if (count == 2)
            {

                ptb.ImageLocation = ("../../image/priroda.jpg");
            }
            if (count == 3)
            {

                ptb.ImageLocation = ("../../image/samolet.jpg");
            }
            if (count == 4)
            {
                
                count = 0;
                ptb.ImageLocation = ("../../image/horosho.jpg");
            }*/
        }
    }
}
