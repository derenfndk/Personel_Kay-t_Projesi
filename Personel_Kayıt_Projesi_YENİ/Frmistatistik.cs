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

namespace Personel_Kayıt_Projesi_YENİ
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-045VOUG;Initial Catalog=PERSONEL_VERİ_TABANI_YENİDEN;Integrated Security=True");
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            //personel sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel_YENİ ",baglanti);
            SqlDataReader dr1= komut1.ExecuteReader();
            while (dr1.Read())
            {
                Lbltoplampersonel.Text = dr1[0].ToString();
            }


            baglanti.Close();

            //evli personel sayısı
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count (*) From  Tbl_Personel_YENİ where Perdurum=1",baglanti);
            SqlDataReader dr2=komut2.ExecuteReader();
            while (dr2.Read())
            {

                Lblevlipersonel.Text = dr2[0].ToString();
            }

            baglanti.Close();

            //bekar personel sayısı 

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select count (*) from Tbl_Personel_YENİ where Perdurum=0",baglanti);
            SqlDataReader dr3=komut3.ExecuteReader();
            while (dr3.Read())
            {
                Lblbekarpersonel.Text = dr3[0].ToString();

            }

            baglanti.Close();

            //Personel sehir

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count (distinct (Persehir)) from Tbl_Personel_YENİ",baglanti);
            SqlDataReader dr4=komut4.ExecuteReader();
            while (dr4.Read())
            {
                Lblpersonelsehir.Text = dr4[0].ToString();

            }



            baglanti.Close();

            //toplam maaş 

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("select sum(Permaas) from Tbl_Personel_YENİ",baglanti);
            SqlDataReader dr5=komut5.ExecuteReader();
            while (dr5.Read())
            {
                Lblpersonelmaas.Text = dr5[0].ToString();   

            }

            baglanti.Close();

            //ortalama maaş

            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("select avg(Permaas) from Tbl_Personel_YENİ",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                Lblortalamamaas.Text = dr6[0].ToString();

            }



            baglanti.Close();
            



            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
