namespace TestUiDemo
{
    partial class UCCek
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.idCust = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.nik = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.cari_idtransaksi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idtiket = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.tujuan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.keberangkatan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reset = new Telerik.WinControls.UI.RadRepeatButton();
            this.tglTransaksi = new Telerik.WinControls.UI.RadDateTimePicker();
            this.waktu = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waktu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(754, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DIPESAN PADA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alamat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sex);
            this.groupBox1.Controls.Add(this.idCust);
            this.groupBox1.Controls.Add(this.nama);
            this.groupBox1.Controls.Add(this.nik);
            this.groupBox1.Location = new System.Drawing.Point(11, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 292);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA DIRI";
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(116, 146);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(277, 130);
            this.alamat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ALAMAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "JENIS KELAMIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NAMA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIK";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(116, 118);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(277, 20);
            this.sex.TabIndex = 7;
            // 
            // idCust
            // 
            this.idCust.Location = new System.Drawing.Point(116, 29);
            this.idCust.Name = "idCust";
            this.idCust.Size = new System.Drawing.Size(277, 20);
            this.idCust.TabIndex = 1;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(116, 92);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(277, 20);
            this.nama.TabIndex = 5;
            // 
            // nik
            // 
            this.nik.Location = new System.Drawing.Point(116, 66);
            this.nik.Name = "nik";
            this.nik.Size = new System.Drawing.Size(277, 20);
            this.nik.TabIndex = 3;
            // 
            // btn_cari
            // 
            this.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari.Location = new System.Drawing.Point(206, 49);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 2;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // cari_idtransaksi
            // 
            this.cari_idtransaksi.Location = new System.Drawing.Point(14, 51);
            this.cari_idtransaksi.Name = "cari_idtransaksi";
            this.cari_idtransaksi.Size = new System.Drawing.Size(176, 20);
            this.cari_idtransaksi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "TUJUAN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idtiket);
            this.groupBox2.Controls.Add(this.status);
            this.groupBox2.Controls.Add(this.harga);
            this.groupBox2.Controls.Add(this.tujuan);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.keberangkatan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(470, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 292);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATA TIKET";
            // 
            // idtiket
            // 
            this.idtiket.Location = new System.Drawing.Point(144, 29);
            this.idtiket.Name = "idtiket";
            this.idtiket.Size = new System.Drawing.Size(259, 20);
            this.idtiket.TabIndex = 1;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(144, 133);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(259, 20);
            this.status.TabIndex = 9;
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(144, 107);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(259, 20);
            this.harga.TabIndex = 7;
            // 
            // tujuan
            // 
            this.tujuan.Location = new System.Drawing.Point(144, 81);
            this.tujuan.Name = "tujuan";
            this.tujuan.Size = new System.Drawing.Size(259, 20);
            this.tujuan.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "STATUS";
            // 
            // keberangkatan
            // 
            this.keberangkatan.Enabled = false;
            this.keberangkatan.Location = new System.Drawing.Point(144, 55);
            this.keberangkatan.Name = "keberangkatan";
            this.keberangkatan.Size = new System.Drawing.Size(259, 20);
            this.keberangkatan.TabIndex = 3;
            this.keberangkatan.Text = "PURWOKERTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "HARGA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID TIKET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "KEBERANGKATAN";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(287, 49);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(68, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "RESET";
            this.reset.ThemeName = "Desert";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // tglTransaksi
            // 
            this.tglTransaksi.CalendarSize = new System.Drawing.Size(290, 320);
            this.tglTransaksi.Enabled = false;
            this.tglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tglTransaksi.Location = new System.Drawing.Point(457, 51);
            this.tglTransaksi.Name = "tglTransaksi";
            this.tglTransaksi.ReadOnly = true;
            this.tglTransaksi.Size = new System.Drawing.Size(155, 20);
            this.tglTransaksi.TabIndex = 6;
            this.tglTransaksi.TabStop = false;
            this.tglTransaksi.Text = "09/06/2019";
            this.tglTransaksi.ThemeName = "Material";
            this.tglTransaksi.Value = new System.DateTime(2019, 6, 9, 13, 32, 24, 0);
            // 
            // waktu
            // 
            this.waktu.CalendarSize = new System.Drawing.Size(290, 320);
            this.waktu.Enabled = false;
            this.waktu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.waktu.Location = new System.Drawing.Point(618, 51);
            this.waktu.Name = "waktu";
            this.waktu.ReadOnly = true;
            this.waktu.Size = new System.Drawing.Size(133, 20);
            this.waktu.TabIndex = 7;
            this.waktu.TabStop = false;
            this.waktu.Text = "13:25:00";
            this.waktu.ThemeName = "Material";
            this.waktu.Value = new System.DateTime(2019, 6, 9, 13, 25, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CARI ID TRANSAKSI";
            // 
            // UCCek
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.waktu);
            this.Controls.Add(this.tglTransaksi);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.cari_idtransaksi);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCCek";
            this.Size = new System.Drawing.Size(890, 458);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waktu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox nik;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox cari_idtransaksi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idtiket;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox tujuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadRepeatButton reset;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox keberangkatan;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadDateTimePicker tglTransaksi;
        private Telerik.WinControls.UI.RadDateTimePicker waktu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idCust;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label12;
    }
}
