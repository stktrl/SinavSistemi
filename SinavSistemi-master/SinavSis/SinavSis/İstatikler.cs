using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinavSis
{
    public partial class İstatikler : UserControl
    {
        public İstatikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-C9KDPNN;Initial Catalog='Yazılım test proje';Integrated Security=True");
        private void istatistikListele(string tarih)
        {
          
            chartControl1.Series["Başlıklar"].Points.Clear();


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select baslik1yanlis, baslik2yanlis, baslik3yanlis, baslik4yanlis, baslik5yanlis from istatistik where ogrenciNo=@ogrenciNo AND sinavTarihi=@sinavTarihi ", baglanti);
            komut.Parameters.AddWithValue("@ogrenciNo", kullaniciBilgisi.kullaniciNo);
            komut.Parameters.AddWithValue("@sinavTarihi", Convert.ToDateTime(tarih).Date);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Başlıklar"].Points.AddPoint(Convert.ToString("baslik1"),Convert.ToInt32(dr[0]));
                chartControl1.Series["Başlıklar"].Points.AddPoint(Convert.ToString("baslik2"), Convert.ToInt32(dr[1]));
                chartControl1.Series["Başlıklar"].Points.AddPoint(Convert.ToString("baslik3"), Convert.ToInt32(dr[2]));
                chartControl1.Series["Başlıklar"].Points.AddPoint(Convert.ToString("baslik4"), Convert.ToInt32(dr[3]));
                chartControl1.Series["Başlıklar"].Points.AddPoint(Convert.ToString("baslik5"), Convert.ToInt32(dr[4]));

            }

            dr.Close();
            komut.Dispose();
            baglanti.Close();
        }
        private void İstatikler_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sinavTarihi from istatistik where ogrenciNo=@ogrenciNo ", baglanti);
            komut.Parameters.AddWithValue("@ogrenciNo", kullaniciBilgisi.kullaniciNo);
            SqlDataReader dr = komut.ExecuteReader();
            Button[] buttons = { button1, button2, button3, button4, button5 };
            int indis = 0;
            while (dr.Read())
            {
                buttons[indis].Visible = true;
                buttons[indis].Text = (Convert.ToString(dr["sinavTarihi"]));
                indis++;
            }

            dr.Close();
            komut.Dispose();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            istatistikListele(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istatistikListele(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            istatistikListele(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            istatistikListele(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            istatistikListele(button5.Text);
        }
    }
}
