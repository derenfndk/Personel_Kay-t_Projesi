namespace Personel_Kayıt_Projesi_YENİ
{
    partial class FrmAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mskmaas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmbsehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtmeslek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btngrafik = new System.Windows.Forms.Button();
            this.Btnistatistik = new System.Windows.Forms.Button();
            this.Btntemizle = new System.Windows.Forms.Button();
            this.Btnguncelle = new System.Windows.Forms.Button();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btnkaydet = new System.Windows.Forms.Button();
            this.Btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelYeniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet = new Personel_Kayıt_Projesi_YENİ.PERSONEL_VERİ_TABANI_YENİDENDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_Personel_YeniTableAdapter = new Personel_Kayıt_Projesi_YENİ.PERSONEL_VERİ_TABANI_YENİDENDataSetTableAdapters.Tbl_Personel_YeniTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelYeniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİ_TABANI_YENİDENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mskmaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Cmbsehir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txtmeslek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txtsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // Mskmaas
            // 
            this.Mskmaas.Location = new System.Drawing.Point(222, 292);
            this.Mskmaas.Name = "Mskmaas";
            this.Mskmaas.Size = new System.Drawing.Size(211, 36);
            this.Mskmaas.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maaş :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(316, 341);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 32);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(228, 341);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 32);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Meslek :";
            // 
            // Cmbsehir
            // 
            this.Cmbsehir.FormattingEnabled = true;
            this.Cmbsehir.Location = new System.Drawing.Point(222, 235);
            this.Cmbsehir.Name = "Cmbsehir";
            this.Cmbsehir.Size = new System.Drawing.Size(211, 36);
            this.Cmbsehir.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durum :";
            // 
            // Txtmeslek
            // 
            this.Txtmeslek.Location = new System.Drawing.Point(222, 386);
            this.Txtmeslek.Name = "Txtmeslek";
            this.Txtmeslek.Size = new System.Drawing.Size(211, 36);
            this.Txtmeslek.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şehir :";
            // 
            // Txtsoyad
            // 
            this.Txtsoyad.Location = new System.Drawing.Point(222, 174);
            this.Txtsoyad.Name = "Txtsoyad";
            this.Txtsoyad.Size = new System.Drawing.Size(211, 36);
            this.Txtsoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = " Soyad :";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(222, 114);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(211, 36);
            this.Txtad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(222, 61);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(211, 36);
            this.Txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel İd :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btngrafik);
            this.groupBox2.Controls.Add(this.Btnistatistik);
            this.groupBox2.Controls.Add(this.Btntemizle);
            this.groupBox2.Controls.Add(this.Btnguncelle);
            this.groupBox2.Controls.Add(this.Btnsil);
            this.groupBox2.Controls.Add(this.Btnkaydet);
            this.groupBox2.Controls.Add(this.Btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(641, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // Btngrafik
            // 
            this.Btngrafik.Location = new System.Drawing.Point(109, 381);
            this.Btngrafik.Name = "Btngrafik";
            this.Btngrafik.Size = new System.Drawing.Size(182, 43);
            this.Btngrafik.TabIndex = 6;
            this.Btngrafik.Text = "Grafikler";
            this.Btngrafik.UseVisualStyleBackColor = true;
            this.Btngrafik.Click += new System.EventHandler(this.Btngrafik_Click);
            // 
            // Btnistatistik
            // 
            this.Btnistatistik.Location = new System.Drawing.Point(109, 326);
            this.Btnistatistik.Name = "Btnistatistik";
            this.Btnistatistik.Size = new System.Drawing.Size(182, 43);
            this.Btnistatistik.TabIndex = 5;
            this.Btnistatistik.Text = "İstatistik";
            this.Btnistatistik.UseVisualStyleBackColor = true;
            this.Btnistatistik.Click += new System.EventHandler(this.Btnistatistik_Click);
            // 
            // Btntemizle
            // 
            this.Btntemizle.Location = new System.Drawing.Point(109, 269);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(182, 43);
            this.Btntemizle.TabIndex = 4;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.UseVisualStyleBackColor = true;
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.Location = new System.Drawing.Point(109, 212);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(182, 43);
            this.Btnguncelle.TabIndex = 3;
            this.Btnguncelle.Text = "Güncelle";
            this.Btnguncelle.UseVisualStyleBackColor = true;
            this.Btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // Btnsil
            // 
            this.Btnsil.Location = new System.Drawing.Point(109, 155);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(182, 43);
            this.Btnsil.TabIndex = 2;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Location = new System.Drawing.Point(109, 101);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(182, 43);
            this.Btnkaydet.TabIndex = 1;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.UseVisualStyleBackColor = true;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // Btnlistele
            // 
            this.Btnlistele.Location = new System.Drawing.Point(109, 47);
            this.Btnlistele.Name = "Btnlistele";
            this.Btnlistele.Size = new System.Drawing.Size(182, 43);
            this.Btnlistele.TabIndex = 0;
            this.Btnlistele.Text = "Listele";
            this.Btnlistele.UseVisualStyleBackColor = true;
            this.Btnlistele.Click += new System.EventHandler(this.Btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelYeniBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "Perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "Perad";
            this.peradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.Width = 125;
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "Persoyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "Persoyad";
            this.persoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            this.persoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "Persehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "Persehir";
            this.persehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            this.persehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "Permaas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "Permaas";
            this.permaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            this.permaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "Perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "Perdurum";
            this.perdurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            this.perdurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "Permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "Permeslek";
            this.permeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            this.permeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelYeniBindingSource
            // 
            this.tblPersonelYeniBindingSource.DataMember = "Tbl_Personel_Yeni";
            this.tblPersonelYeniBindingSource.DataSource = this.pERSONEL_VERİ_TABANI_YENİDENDataSet;
            // 
            // pERSONEL_VERİ_TABANI_YENİDENDataSet
            // 
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet.DataSetName = "PERSONEL_VERİ_TABANI_YENİDENDataSet";
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1060, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_Personel_YeniTableAdapter
            // 
            this.tbl_Personel_YeniTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1153, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1277, 731);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelYeniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİ_TABANI_YENİDENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox Mskmaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmbsehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtmeslek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btngrafik;
        private System.Windows.Forms.Button Btnistatistik;
        private System.Windows.Forms.Button Btntemizle;
        private System.Windows.Forms.Button Btnguncelle;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.Button Btnlistele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PERSONEL_VERİ_TABANI_YENİDENDataSet pERSONEL_VERİ_TABANI_YENİDENDataSet;
        private System.Windows.Forms.BindingSource tblPersonelYeniBindingSource;
        private PERSONEL_VERİ_TABANI_YENİDENDataSetTableAdapters.Tbl_Personel_YeniTableAdapter tbl_Personel_YeniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

