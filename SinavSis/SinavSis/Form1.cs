﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SinavSis
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-C9KDPNN;Initial Catalog=Sinav;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string dummyun = textEdit1.Text;
            string dummypw = textEdit2.Text;
            baglanti.Open();

            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM ogrenciBilgi WHERE KullanıcıAdı=@userid AND Sifre=@password", baglanti))
            {
                StrQuer.Parameters.AddWithValue("@userid", dummyun);
                StrQuer.Parameters.AddWithValue("@password", dummypw);
                SqlDataReader dr = StrQuer.ExecuteReader();
                if(dr.HasRows)
                {
                    labelControl3.Visible = false;
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                 else
                 {
                    labelControl3.Visible = true;

                }
                baglanti.Close();
            }
           

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            string ogretmenId = textEdit4.Text;
            string ogretmenSif = textEdit3.Text;
            baglanti.Open();

            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM ogretmenBilgi WHERE ogretmenKullanıcıAdi=@userid AND Sifre=@password", baglanti))
            {
                StrQuer.Parameters.AddWithValue("@userid", ogretmenId);
                StrQuer.Parameters.AddWithValue("@password", ogretmenSif);
                SqlDataReader dr = StrQuer.ExecuteReader();
                if (dr.HasRows)
                {
                    labelControl5.Visible = false;
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    labelControl5.Visible = true;

                }
                baglanti.Close();
            }


            /*
            try
            {
                baglanti.Open();
                string sql = "Select * from ogretmenBilgi where ogretmenKullanıcıAdi=@adi AND Sifre=@sifresi";
                SqlParameter prm4 = new SqlParameter("adi", textEdit4.Text.Trim());
                SqlParameter prm3 = new SqlParameter("sifresi", textEdit3.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm4);
                komut.Parameters.Add(prm3);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    labelControl5.Visible = false;
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();

                }
            }
            catch (Exception)
            {
                labelControl5.Visible = true;
                
                
            }
            */
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
    }


