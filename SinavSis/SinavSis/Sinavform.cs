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

namespace SinavSis
{
    public partial class Sinavform : Form
    {
        public Sinavform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaMenu f1 = new AnaMenu();
            f1.Show();
            this.Hide();
        }
        int sayac = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            sayactimer += progressBar1.Maximum - progressBar1.Value + 1;

            if (radioButton1.Checked)
            {
                if (radioButton1.Text == Dogrusık.ToString());
                MessageBox.Show("Doğru");
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text == Dogrusık.ToString()) ;
                MessageBox.Show("Yanlış");
            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text == Dogrusık.ToString()) ;
                MessageBox.Show("Yanlış");
            }
            if (radioButton4.Checked)
            {
                if (radioButton4.Text == Dogrusık.ToString()) ;
                MessageBox.Show("Yanlış");
            }


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            sayactimer += progressBar1.Maximum - progressBar1.Value ;
        }
        
        int sayactimer = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {

           
                sayactimer--;
                progressBar1.Value = sayactimer;
                label2.Text = progressBar1.Value.ToString();
          

                if (sayactimer == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Süre Doldu.");
                    sayactimer += 15;
                    button1.PerformClick();
                    progressBar1.Value = sayactimer;
                    label2.Text = progressBar1.Value.ToString();
                    timer1.Start();
                }           
        }
        string Dogrusık = "";
        private void Sinavform_Load(object sender, EventArgs e)
        {
            timer1.Start();

            
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J148P14;Initial Catalog=Sinav;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TOP 5 Soru,ASıkkı,BSıkkı,CSıkkı,DSıkkı,DogruCevap from tbl_Soru order by newid()", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
                label1.Text = dr["Soru"].ToString();
               
                radioButton1.Text = dr["ASıkkı"].ToString();
                radioButton2.Text = dr["BSıkkı"].ToString();
                radioButton3.Text = dr["CSıkkı"].ToString();
                radioButton4.Text = dr["DSıkkı"].ToString();
                Dogrusık = dr["DogruCevap"].ToString();


            }
            dr.Close();
            komut.Dispose();
            baglanti.Close();

            
        



        }

       
    }
}
