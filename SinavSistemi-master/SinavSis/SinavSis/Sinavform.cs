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
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-C9KDPNN;Initial Catalog='Yazılım test proje';Integrated Security=True");
        Test tests = new Test();
        List<soru> sorus = new List<soru>();
        int cevap;
        int soruSayisi=0;
        int toplamYanlis = 0;
        public void istatistikKAyit()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into istatistik(sinavTarihi,yanlisSayisi,ogrenciNo,baslik1yanlis,baslik2yanlis,baslik3yanlis,baslik4yanlis,baslik5yanlis) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut.Parameters.AddWithValue("@p1", DateTime.Now.Date);
            komut.Parameters.AddWithValue("@p2", toplamYanlis);
            komut.Parameters.AddWithValue("@p3", kullaniciBilgisi.kullaniciNo);
            for (int i = 0; i < 5; i++) {
                switch (tests.baslikId[i])
                {
                    
                    case 1:
                        komut.Parameters.AddWithValue("@p4", tests.basliklarinYanlisSayilari[i]);
                        break;
                    case 2:
                        komut.Parameters.AddWithValue("@p5", tests.basliklarinYanlisSayilari[i]);
                        break;
                    case 3:
                        komut.Parameters.AddWithValue("@p6", tests.basliklarinYanlisSayilari[i]);
                        break;
                    case 4:
                        komut.Parameters.AddWithValue("@p7", tests.basliklarinYanlisSayilari[i]);
                        break;
                    case 5:
                        komut.Parameters.AddWithValue("@p8", tests.basliklarinYanlisSayilari[i]);
                        break;

    


            }
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void soruToplama()
        {
           baglanti.Open();
            for (int index = 0; index <5; index++)
            {
                
                
                SqlCommand komut = new SqlCommand("Select TOP (@soruSayisi) soru, dogru, yanlis1, yanlis2, yanlis3,resim from Sorular where baslikId=@baslikID ", baglanti);
                komut.Parameters.AddWithValue("@soruSayisi",(12-index ));
                komut.Parameters.AddWithValue("@baslikId", tests.baslikId[index]);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    soru Soru = new soru();
                    Soru.soruMetni = Convert.ToString(dr["soru"]);
                    Soru.dogruCevap = Convert.ToString(dr["dogru"]);
                    Soru.siklar[0] = Convert.ToString(dr["yanlis1"]);
                    Soru.siklar[1] = Convert.ToString(dr["yanlis2"]);
                    Soru.siklar[2] = Convert.ToString(dr["yanlis3"]);
                    Soru.resimYolu = Convert.ToString(dr["resim"]);
                    sorus.Add(Soru);
                }
                dr.Close();
            }
            baglanti.Close();
        }
        public int soruSorma()
        {
            RadioButton[] radioButton = new RadioButton[4] {radioButton1,radioButton2,radioButton3,radioButton4 };
            int index = 0;
            if (sorus.Count == 0)
            {
                MessageBox.Show("Test Bitti. Menüye yönlendiriliyorsunuz.");
                OgrenciForm ogrenciForm = new OgrenciForm();
                istatistikKAyit();
                ogrenciForm.Show();
                this.Hide();

                
                


            }
                
            foreach(soru sor in sorus)
            {
                if (sor.resimYolu != null)
                {
                    pictureBox1.ImageLocation = sor.resimYolu;


                } 
                label1.Text = Convert.ToString(sor.soruMetni);
                Random randomSayi = new Random();
                int no = randomSayi.Next(0, 4);
                radioButton[no].Text = sor.dogruCevap;
                for (int indis = 0; indis < 4; indis++)
                {
                    if (indis == no)
                    {
                        
                        continue;
                    }
                        
                    else
                    {
                        
                        radioButton[indis].Text = sor.siklar[index];
                        index++;

                    }

                  
                    

                }
                sorus.Remove(sor);
                return no;


            }
            return 0;

        }
        public void baslikSiralama()
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select baslik1yanlis, baslik2yanlis, baslik3yanlis, baslik4yanlis, baslik5yanlis from istatistik where ogrenciNo=@ogrenciNo AND sinavTarihi=@sinavTarihi ", baglanti);
            komut.Parameters.AddWithValue("@sinavTarihi", kullaniciBilgisi.sonSinavTarihi);
            komut.Parameters.AddWithValue("@ogrenciNo", kullaniciBilgisi.kullaniciNo);
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                for (int indis = 0; indis < 5; indis++)
                {
                    tests.basliklarinYanlisSayilari[indis] = Convert.ToInt32(dr["baslik" + tests.baslikId[indis] + "yanlis"]);

                }

            }
            dr.Close();
            komut.Dispose();
            baglanti.Close();
            int geciciDeger;
            int geciciBaslikId;
            for (int indis = 0; indis < 5; indis++)
            {
                for (int indis2 = 0; indis2 < 5; indis2++)
                {
                    if (tests.basliklarinYanlisSayilari[indis] > tests.basliklarinYanlisSayilari[indis2])
                    {
                        geciciDeger = tests.basliklarinYanlisSayilari[indis];
                        tests.basliklarinYanlisSayilari[indis] = tests.basliklarinYanlisSayilari[indis2];
                        tests.basliklarinYanlisSayilari[indis2] = geciciDeger;
                        geciciBaslikId = tests.baslikId[indis];
                        tests.baslikId[indis] = tests.baslikId[indis2];
                        tests.baslikId[indis2] = geciciBaslikId;
                    }



                }
                

            }
            Array.Clear(tests.basliklarinYanlisSayilari,0,5);
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciForm f2 = new OgrenciForm();
            f2.Show();
            this.Hide();

        }
        int sayac = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            RadioButton[] radioButton = new RadioButton[4] { radioButton1, radioButton2, radioButton3, radioButton4 };
            if (radioButton[cevap].Checked)
            {
               
                cevap = soruSorma();
                soruSayisi++;
            }
            else
            {
                if (soruSayisi <= 12)
                {
                   tests.basliklarinYanlisSayilari[0]++;
                    toplamYanlis++;
                    soruSayisi++;
                }else if (soruSayisi > 12 && soruSayisi <= 23)
                {
                    tests.basliklarinYanlisSayilari[1]++;
                    toplamYanlis++;
                    soruSayisi++;
                }
                else if (soruSayisi>23 && soruSayisi <= 33)
                {
                    tests.basliklarinYanlisSayilari[2]++;
                    toplamYanlis++;
                    soruSayisi++;
                }
                else if(soruSayisi>33 && soruSayisi <= 42)
                {
                    tests.basliklarinYanlisSayilari[3]++;
                    toplamYanlis++;
                    soruSayisi++;
                }
                else if(soruSayisi>42 && soruSayisi <= 50)
                {
                    tests.basliklarinYanlisSayilari[4]++;
                    toplamYanlis++;
                    soruSayisi++;
                }else if (soruSayisi == 50)
                {
                    MessageBox.Show("Test Bitti. Menüye yönlendiriliyorsunuz.");
                    OgrenciForm ogrenciForm = new OgrenciForm();
                    istatistikKAyit();
                    ogrenciForm.Show();
                    this.Hide();


                }


                cevap = soruSorma();


            }

            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            
        }

        int dakika = 60;
        int saniye = 60;
        int sayactimer=3600;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayactimer -= 1;
            saniye -= 1;
            labelsaniye.Text = saniye.ToString();
            labeldakika.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika = dakika - 1;
                labeldakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (labeldakika.Text=="-1" || sayactimer == 0)
            {
                timer1.Stop();
                labeldakika.Text = "00";
                labelsaniye.Text = "00";
                MessageBox.Show("Süreniz BİTTİ. Anamenüye yönlendiriliyorsunuz.");
                button3.PerformClick();


            }
            progressBar1.Value = sayactimer;             
                         
        }
        
        private void Sinavform_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (kullaniciBilgisi.sonSinavTarihi != DateTime.MinValue)
            {
                baslikSiralama();
            }
            soruToplama();
            soruSayisi++;
            cevap=soruSorma();
                       

        }

      
    }
}
