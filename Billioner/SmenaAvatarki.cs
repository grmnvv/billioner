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
    public partial class SmenaAvatarki : Form
    {
        public string q = "";
        public SmenaAvatarki()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
            q = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            q = "4uvak"; 
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            q = "korol";
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            q = "homer";
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            q = "bdender";
        }

        private void SmenaAvatarki_Load(object sender, EventArgs e)
        {

        }
    }
}
