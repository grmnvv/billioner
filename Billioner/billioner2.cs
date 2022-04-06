using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Billioner
{
    public partial class billioner2 : Form
    {
        //Объявление переменных!
        public string y = "";
        public string r = "";
        int NVopr = 0;
        int h = 0, h1 = 0; 
        int s4et = 1;
        int sitem = 1;
        int fifty = 0; 
        int podskazka = 0;
        Random rnd = new Random();
        List<string> lst = new List<string>();
        List<string> otv = new List<string>();
        List<string> prav = new List<string>();
        List<int> vopr = new List<int>();
        List<RadioButton> spRB = new List<RadioButton>();
        public billioner2()
        {
            InitializeComponent();
        }

        //ВОЙДЫ, НЕ ТРОГРАТЬ НИ В КОЕМ СЛУЧАЕ

        private void na4alo() //Обнуление всех переменных, создание н.у.
        {
            
            sitem = 1;
            podskazka = 0;
            s4et = 0;
            vopr.Clear();
            foreach (RadioButton aaa in spRB)
            {
                aaa.Text = "";
            }
            txtAnsw.Text = "";
            for (int i = 0; i <= 11; i++)
            {
                lstMoney.SetItemChecked(i, false);
            }
        }

        private void proverk() //ЗАГРУЗКА ВОПРОСОВ И ВАРИАНТОВ ОТВЕТОВ
        {
                do
                {
                    NVopr = rnd.Next(20);
                } while (vopr.Contains(NVopr)); vopr.Add(NVopr);
                for (int i = 0; i <= 3; i++)
                {
                    do
                    {
                        h = rnd.Next(0, 4);
                    } while (spRB[h].Text != "");
                    spRB[h].Text = otv[(NVopr * 4) + i];
                }
                txtAnsw.Text = lst[NVopr];
                foreach (RadioButton aaa in spRB)
                {
                    aaa.BackColor = this.BackColor;
                    aaa.Checked = false;
                }
            }

        private void ifs() //Проверка выиграша и защита от дурака
        {
            if (sitem == 0)
            {
                MessageBox.Show("Поздравляю с победой, вот сколько вы выиграли:" + lstMoney.Items[sitem].ToString() + "\r\nДавайте еще разок сыграем");
                btnGo.Enabled = true;
                btnOK.Enabled = false;
                na4alo();
            }

            if (sitem == 12)
            {
                sitem = 11;
            }
        }


        //ВОЙДЫ ЗАКОНЧИЛИСЬ


        private void billioner2_FormClosed(object sender, FormClosedEventArgs e) //Закрытие формы
        {
            Application.Exit();
        }

        private void btnGo_Click(object sender, EventArgs e) //Начало игры/Кнопка погнали
        {
            sitem = 11;
            s4et++;
            do
            {
                NVopr = rnd.Next(20);
            } while (vopr.Contains(NVopr)); vopr.Add(NVopr);
            //Загрузка ответов в случайном порядке на радиокнопки
            if (s4et != 13)
            {
                for (int i = 0; i <= 3; i++)
                {
                    do
                    {
                        h = rnd.Next(0, 4);
                    } while (spRB[h].Text != "");
                    spRB[h].Text = otv[(NVopr * 4) + i];
                }
            }
            txtAnsw.Text = lst[NVopr];
            btnOK.Enabled = true;
            btnGo.Enabled = false;
            pnlCh.Visible = true;
            btnPod.Enabled = true;
            btnGo.ForeColor = Color.Red;
            btnOK.ForeColor = Color.Green;
            btnPod.ForeColor = Color.Green;
        }



        private void btnOK_Click(object sender, EventArgs e) //Продолжение игры/кнопка ответить
        {
            foreach(RadioButton aa in spRB)
            {
                aa.Visible = true;
            }
            if (s4et == 13) //Конец игры
            {
                btnGo.Enabled = true;
                btnOK.Enabled = false;
                na4alo();
                MessageBox.Show("Сожалею, вы не выиграли 1 000 000, вот сколько вы выиграли:" + lstMoney.Items[sitem].ToString() + "\r\nДавайте еще разок сыграем");
                
            }
            s4et++;
            foreach (RadioButton aaa in spRB) //Проверка на верный/неверный ответ
            {
                if (aaa.Checked)
                {
                    if (aaa.Text == prav[NVopr])
                    {
                        aaa.BackColor = Color.Green;
                        MessageBox.Show("Верно!");

                        txtAnsw.Text = "";
                        foreach (RadioButton aaaa in spRB)
                        {
                            aaaa.Text = "";
                        }
                        proverk();
                        lstMoney.SetItemChecked(sitem, true);
                        ifs();
                        sitem--;
                    }
                    else
                    {
                        foreach (RadioButton aa in spRB)
                        {
                            if (aa.Text == prav[NVopr])
                            {
                                aa.BackColor = Color.Green;
                            }
                        }
                        aaa.BackColor = Color.Red;
                        MessageBox.Show("Неверно!\r\nПравильный ответ:\r\n" + prav[NVopr]);
                        txtAnsw.Text = "";
                        foreach (RadioButton aaaa in spRB)
                        {
                            aaaa.Text = "";
                        }
                        proverk();
                        sitem++;
                        ifs();
                        lstMoney.SetItemChecked(sitem, false);
                    }
                }
                aaa.BackColor = Color.DarkCyan;
            }
        }

        private void rbn1_CheckedChanged(object sender, EventArgs e) //Смена цветафона у радиокнопок
        {
            RadioButton abc = (RadioButton)sender;
            foreach (RadioButton aaa in spRB)
            {
                aaa.BackColor = Color.DarkCyan;
            }
            abc.BackColor = Color.Yellow;
        }

        private void pnlCh_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnFotka_Click(object sender, EventArgs e)
        {
        }

        private void btnPod_Click(object sender, EventArgs e) //Подсказка 50 на 50
        {
            
            podskazka++;
            if (podskazka > 2) //Проверка на кол-во подсказок
            {
                MessageBox.Show("Вы использовали все свои подсказки!");
                btnPod.Enabled = false;
                btnPod.ForeColor = Color.Red;
            }
            else
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (spRB[i].Text == prav[NVopr])
                    {
                        fifty = i;
                    }
                }

                h = rnd.Next(0, 4); h1 = rnd.Next(0, 4);
                while (h == fifty) //Мозги кнопки 50 на 50
                {
                    h = rnd.Next(0, 4);
                }
                while (h1 == fifty || h1 == h)
                {
                    h1 = rnd.Next(0, 4);
                }

                spRB[h].Visible = false;
                spRB[h1].Visible = false;
            }
        }



        private void billioner2_Load(object sender, EventArgs e) //Загрузка формы
        {
            label1.Text = y;
            if (r == "") //Загрузка аватарки
            {
                pic1.Image = Properties.Resources.misha;
            }
            else
            {
                Object res = Properties.Resources.ResourceManager.GetObject(r);
                pic1.Image = (Bitmap)res;
                pic1.Load(r);
            }
            //Добавление всех радиокнопок в коллекцию
            spRB.Add(rbn1);
            spRB.Add(rbn2);
            spRB.Add(rbn3);
            spRB.Add(rbn4);


            StreamReader myfile; //Добавление вопросов в коллекцию
            myfile = new StreamReader("answers.txt", Encoding.UTF8);
            string abc = "";
            while ((abc = myfile.ReadLine()) != null)
            {
                lst.Add(abc);
            }


            StreamReader myfile2; //Добавление ответов в коллекцию
            myfile2 = new StreamReader("otveti.txt", Encoding.UTF8);
            string abcd = "";
            while ((abcd = myfile2.ReadLine()) != null)
            {
                otv.Add(abcd);
            }
            myfile2.Close();


            StreamReader myfile3; //Добавление правильных ответов в коллекцию
            myfile3 = new StreamReader("otveti2.txt", Encoding.UTF8);
            string abcde = "";
            while ((abcde = myfile3.ReadLine()) != null)
            {
                prav.Add(abcde);
            }
            myfile3.Close();
        }
    }
}

