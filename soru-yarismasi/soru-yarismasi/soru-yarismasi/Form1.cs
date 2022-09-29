using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonra.Enabled = true;

            label5.Text = BtnB.Text;
            if (label5.Text==label6.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonra.Enabled = true;

            label5.Text = BtnC.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonra.Enabled = true;

            label5.Text = BtnD.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonra.Enabled = true;

            label6.Text = BtnA.Text;
            if (label5.Text==label6.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
            }
        }

        private void BtnSonra_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonra.Enabled = false;



            soruno++;
            LblSno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "cumhuriyet kaç yılında ilan edilmiştir";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label5.Text = "1923";
            }

            if (soruno==2)
            {
                richTextBox1.Text = "hangi il ege bölgemizde bulunmaz";
                BtnA.Text = "izmir";
                BtnB.Text = "balıkesir";
                BtnC.Text = "aydın";
                BtnD.Text = "manisa";
                label5.Text = "balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "son kuşlar hangi yazarımıza aittir";
                BtnA.Text = "sait faik";
                BtnB.Text = "cemal sureya";
                BtnC.Text = "attila ilhan";
                BtnD.Text = "reşat nuri";
                label5.Text = "sait faik";
                BtnSonra.Text = "sonuclar";
            }

            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonra.Enabled = false;
                MessageBox.Show("doğru" + dogru + "\n" + "yanlış :" + yanlis);
            }
        }
    }
}
