using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayıt_Projesi_YENİ
{
    public partial class Frmraporlar : Form
    {
        public Frmraporlar()
        {
            InitializeComponent();
        }

        private void Frmraporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pERSONEL_VERİ_TABANI_YENİDENDataSet.Tbl_Personel_Yeni' table. You can move, or remove it, as needed.
            this.tbl_Personel_YeniTableAdapter.Fill(this.pERSONEL_VERİ_TABANI_YENİDENDataSet.Tbl_Personel_Yeni);

            this.reportViewer1.RefreshReport();
        }
    }
}
