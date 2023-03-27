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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-045VOUG;Initial Catalog=PERSONEL_VERİ_TABANI_YENİDEN;Integrated Security=True");

        void temizle()
        {
            Txtad.Text = "";
            Txtsoyad.Text = "";
            Txtmeslek.Text = "";
            Txtid.Text = "";
            Mskmaas.Text = "";
            Cmbsehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked=false;
            Txtad.Focus();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.tbl_Personel_YeniTableAdapter.Fill(this.pERSONEL_VERİ_TABANI_YENİDENDataSet.Tbl_Personel_Yeni);

        }

        private void Btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_Personel_YeniTableAdapter.Fill(this.pERSONEL_VERİ_TABANI_YENİDENDataSet.Tbl_Personel_Yeni);
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel_YENİ (Perad,Persoyad,Persehir,Permaas,Permeslek,Perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",Txtad.Text);
            komut.Parameters.AddWithValue("@p2",Txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",Cmbsehir.Text);
            komut.Parameters.AddWithValue("@p4",Mskmaas.Text);
            komut.Parameters.AddWithValue("@p5",Txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6",label8.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Personel Eklendi");



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label8.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                label8.Text = "False";
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil =new SqlCommand("delete from Tbl_Personel_YENİ where Personelid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", Txtid.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Cmbsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Mskmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text=="True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text=="false")
            {
                radioButton2.Checked = true;
            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutgucelle = new SqlCommand("update Tbl_Personel_YENİ Set Perad=@a1,Persoyad=@a2,Persehir=@a3,Permaas=@a4,Perdurum=@a5,Permeslek=@a6 where Personelid=@a7",baglanti);
            komutgucelle.Parameters.AddWithValue("@a1", Txtad.Text);
            komutgucelle.Parameters.AddWithValue("@a2",Txtsoyad.Text);
            komutgucelle.Parameters.AddWithValue("@a3", Cmbsehir.Text);
            komutgucelle.Parameters.AddWithValue("@a4",Mskmaas.Text);
            komutgucelle.Parameters.AddWithValue("@a5",label8.Text);
            komutgucelle.Parameters.AddWithValue("@a6",Txtmeslek.Text);
            komutgucelle.Parameters.AddWithValue("@a7",Txtid.Text);
            komutgucelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgi güncellendi");

        }

        private void Btnistatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr1= new Frmistatistik();
            fr1.Show();
        }

        private void Btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm2 = new FrmGrafikler();
            frm2.Show();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmraporlar frmrapor = new Frmraporlar();
            frmrapor.Show();
        }
    }
}
