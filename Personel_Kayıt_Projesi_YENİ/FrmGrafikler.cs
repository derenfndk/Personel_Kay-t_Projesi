﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayıt_Projesi_YENİ
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-045VOUG;Initial Catalog=PERSONEL_VERİ_TABANI_YENİDEN;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select Persehir,count(*)from Tbl_Personel_YENİ group by Persehir",baglanti);
            SqlDataReader dr1=komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }


            baglanti.Close();

            baglanti.Open();

            SqlCommand komut2g2 = new SqlCommand("select Permeslek,avg(Permaas) from Tbl_Personel_YENİ group by Permeslek",baglanti);
            SqlDataReader dr2=komut2g2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);

            }

            baglanti.Close();





        }
    }
}
