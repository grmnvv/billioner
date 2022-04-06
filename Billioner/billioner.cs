using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billioner
{
    public partial class billioner : Form
    {
        //ОБЪЯВЛЕНИЕ ПЕРЕМЕННЫХ
        public string Nm = "";
        public int IN = 0;
        public string w = "";







        public billioner()
        {
            InitializeComponent();
        }

        private void billioner_Load(object sender, EventArgs e)
        {
            //ВЕСЬ ТЕКСТ НА ФОРМЕ И ЗАГРУЗКА В СПИСКИ ВОПРОСОВ
            lblPr.Text = "Добрый день, \r\nсегодня мы сыграем в игру. \r\nНо не бойтесь, игра не на жизнь, \r\nа на деньги. Может быть, вы \r\nсегодня уйдете победителем!";
        }


        private void btnN4_Click(object sender, EventArgs e) //ИИ
        {Nm = txtNm.Text;
            
            
            if(txtNm.Text == "")
            {
                MessageBox.Show("КАК ТЕБЯ ЗОВУТ?");
            }
            else
            {
                MessageBox.Show("Добро пожаловать, " + Nm);
                pnFr.Visible = true;
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void nudIN_ValueChanged(object sender, EventArgs e)
        {
            IN = (int)nudIN.Value;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e) //Открытие окна со сменой аватарки
        {
            SmenaAvatarki myfor = new SmenaAvatarki();



            myfor.ShowDialog();
            w = myfor.q;
            myfor.Dispose();
            
        }

        private void btnPognali_Click(object sender, EventArgs e) //Переход на следующую форму
        {

            if (IN > 40 && IN < 50)
            {
                MessageBox.Show("Отлично! Добро пожаловать в игру!");
                billioner2 myform = new billioner2();
                this.Visible = false;
                myform.y = Nm;
                myform.r = w;
                myform.ShowDialog();
                myform.Dispose();
            }
            else
            {
                MessageBox.Show("Иди учи историю!");
            }
        }
    }
}
