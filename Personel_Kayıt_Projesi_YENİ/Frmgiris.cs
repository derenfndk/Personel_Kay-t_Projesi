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
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-045VOUG;Initial Catalog=PERSONEL_VERİ_TABANI_YENİDEN;Integrated Security=True");
        private void Btngirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Yonetici where Kullaniciad=@p1 and Sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",Txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2",Txtsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frmana = new FrmAnaForm();
                frmana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }



            baglanti.Close();   


           
        }

        private void Frmgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
