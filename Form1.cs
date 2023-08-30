using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sqlsoruUygulamasi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan=new SqlConnection("Data Source=IRFAN\\SQLEXPRESS;Initial Catalog=sorular;Integrated Security=True");
            
        int sorusayisi = 0, sure = 10, dogru = 0, yanlis = 0, puan = 0;
        private void siklaripasifyap()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void siklariaktiflestir()
        {
            button1.Enabled = true;
            button2.Enabled=true;
            button3.Enabled=true;
            button4.Enabled=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            siklaripasifyap();
            label6.Visible = true;
            label2.Visible = true;
            if (button4.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlis++;
                lblyanlis.Text=yanlis.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure - 1;
            lblsure.Text= sure.ToString();
            if (sure == 0)
            {
                timer1.Enabled = false;
                siklaripasifyap();
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button6.Visible = false;
            label6.Visible = false;
            label2.Visible = false;
            richTextBox1.Enabled = false;
            siklaripasifyap();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler" + "," + lblpuan.Text + " " + "puan" + " " + "alarak" + " " + "soruları" + " " + "bitirdiniz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            siklaripasifyap();
            label6.Visible = true;
            label2.Visible = true;
            if (button3.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            siklaripasifyap();
            label6.Visible = true;
            label2.Visible = true;
            if (button2.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            siklaripasifyap();
            label6.Visible = true;
            label2.Visible = true;
            if (button1.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text= dogru.ToString();
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label2.Visible = false;
            timer1.Enabled = true;
            sure = 11;//11 yapmamın sebebi direkt olarak 10 gözükmüyor 11 yapınca 10dan başlatıyor.
            siklariaktiflestir();
            sorusayisi++;
            lblsoru.Text=sorusayisi.ToString();
            button5.Text = "İLERİ";
            if (sorusayisi == 1) { 
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from soru1 order by NEWID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                {

                    button1.Text = (oku["a"]).ToString();
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = (oku["soru"].ToString());
                    label6.Text = (oku["dogru"].ToString());
                    }
            }
            baglan.Close();
        }
            if (sorusayisi == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru2 order by NEWID()",baglan);
                SqlDataReader oku=  komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"]).ToString();
                    button2.Text= (oku["b"].ToString());
                    button3.Text= (oku["c"].ToString());
                    button4.Text= (oku["d"].ToString());
                    richTextBox1.Text = (oku["soru"].ToString());
                    label6.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if(sorusayisi == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {
                    button1.Text= (oku["a"]).ToString();
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());   
                    button4.Text= (oku["d"].ToString());
                    richTextBox1.Text = (oku["soru"].ToString());
                    label6.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if(sorusayisi == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru4 order by NEWID()", baglan);
                SqlDataReader oku= komut.ExecuteReader();
                while(oku.Read())
                {
                    button1.Text = (oku["a"]).ToString();
                    button2.Text= (oku["b"].ToString());
                    button3.Text= (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = (oku["soru"].ToString());
                    label6.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if(sorusayisi == 5)
            {
                button5.Enabled = false;
                button6.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru5 order by NEWID()", baglan);
                SqlDataReader oku=komut.ExecuteReader();
                while(oku.Read())
                {
                    button1.Text= (oku["a"]).ToString();
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text= (oku["d"].ToString());
                    richTextBox1.Text = (oku["soru"].ToString());
                    label6.Text = (oku["dogru"].ToString());
                    

                }
                baglan.Close();
            }
      }
    }
}
