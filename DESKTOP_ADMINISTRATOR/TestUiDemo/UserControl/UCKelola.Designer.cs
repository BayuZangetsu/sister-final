namespace TestUiDemo
{
    partial class UCKelola
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hapus = new Telerik.WinControls.UI.RadButton();
            this.edit = new Telerik.WinControls.UI.RadButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.harga = new MetroFramework.Controls.MetroTextBox();
            this.tujuan = new MetroFramework.Controls.MetroTextBox();
            this.idTiket = new MetroFramework.Controls.MetroTextBox();
            this.tambah = new Telerik.WinControls.UI.RadButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pesanResponse = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hapus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tambah)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(562, 385);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 73);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGEMEN TIKET";
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.Red;
            this.hapus.ForeColor = System.Drawing.SystemColors.Control;
            this.hapus.Location = new System.Drawing.Point(109, 339);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(100, 43);
            this.hapus.TabIndex = 0;
            this.hapus.Text = "HAPUS";
            this.hapus.ThemeName = "TelerikMetroTouch";
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Chartreuse;
            this.edit.ForeColor = System.Drawing.SystemColors.Control;
            this.edit.Location = new System.Drawing.Point(3, 339);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 43);
            this.edit.TabIndex = 0;
            this.edit.Text = "EDIT";
            this.edit.ThemeName = "TelerikMetroTouch";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 385);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pesanResponse);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Controls.Add(this.harga);
            this.panel3.Controls.Add(this.tujuan);
            this.panel3.Controls.Add(this.idTiket);
            this.panel3.Controls.Add(this.edit);
            this.panel3.Controls.Add(this.tambah);
            this.panel3.Controls.Add(this.hapus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(568, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 385);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "HARGA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "TUJUAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID TIKET";
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(322, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "PANEL EDITING RESOURCE";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // harga
            // 
            // 
            // 
            // 
            this.harga.CustomButton.Image = null;
            this.harga.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.harga.CustomButton.Name = "";
            this.harga.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.harga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.harga.CustomButton.TabIndex = 1;
            this.harga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.harga.CustomButton.UseSelectable = true;
            this.harga.CustomButton.Visible = false;
            this.harga.Lines = new string[0];
            this.harga.Location = new System.Drawing.Point(109, 185);
            this.harga.MaxLength = 32767;
            this.harga.Name = "harga";
            this.harga.PasswordChar = '\0';
            this.harga.PromptText = "HARGA";
            this.harga.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.harga.SelectedText = "";
            this.harga.SelectionLength = 0;
            this.harga.SelectionStart = 0;
            this.harga.ShortcutsEnabled = true;
            this.harga.Size = new System.Drawing.Size(201, 23);
            this.harga.TabIndex = 2;
            this.harga.UseSelectable = true;
            this.harga.WaterMark = "HARGA";
            this.harga.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.harga.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tujuan
            // 
            // 
            // 
            // 
            this.tujuan.CustomButton.Image = null;
            this.tujuan.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.tujuan.CustomButton.Name = "";
            this.tujuan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tujuan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tujuan.CustomButton.TabIndex = 1;
            this.tujuan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tujuan.CustomButton.UseSelectable = true;
            this.tujuan.CustomButton.Visible = false;
            this.tujuan.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tujuan.Lines = new string[0];
            this.tujuan.Location = new System.Drawing.Point(109, 156);
            this.tujuan.MaxLength = 32767;
            this.tujuan.Name = "tujuan";
            this.tujuan.PasswordChar = '\0';
            this.tujuan.PromptText = "TUJUAN";
            this.tujuan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tujuan.SelectedText = "";
            this.tujuan.SelectionLength = 0;
            this.tujuan.SelectionStart = 0;
            this.tujuan.ShortcutsEnabled = true;
            this.tujuan.Size = new System.Drawing.Size(201, 23);
            this.tujuan.TabIndex = 2;
            this.tujuan.UseSelectable = true;
            this.tujuan.WaterMark = "TUJUAN";
            this.tujuan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tujuan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idTiket
            // 
            // 
            // 
            // 
            this.idTiket.CustomButton.Image = null;
            this.idTiket.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.idTiket.CustomButton.Name = "";
            this.idTiket.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idTiket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTiket.CustomButton.TabIndex = 1;
            this.idTiket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTiket.CustomButton.UseSelectable = true;
            this.idTiket.CustomButton.Visible = false;
            this.idTiket.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.idTiket.Lines = new string[0];
            this.idTiket.Location = new System.Drawing.Point(109, 51);
            this.idTiket.MaxLength = 32767;
            this.idTiket.Name = "idTiket";
            this.idTiket.PasswordChar = '\0';
            this.idTiket.PromptText = "ID TIKET";
            this.idTiket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTiket.SelectedText = "";
            this.idTiket.SelectionLength = 0;
            this.idTiket.SelectionStart = 0;
            this.idTiket.ShortcutsEnabled = true;
            this.idTiket.Size = new System.Drawing.Size(201, 23);
            this.idTiket.TabIndex = 1;
            this.idTiket.UseSelectable = true;
            this.idTiket.WaterMark = "ID TIKET";
            this.idTiket.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idTiket.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.Blue;
            this.tambah.ForeColor = System.Drawing.SystemColors.Control;
            this.tambah.Location = new System.Drawing.Point(215, 339);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(100, 43);
            this.tambah.TabIndex = 0;
            this.tambah.Text = "TAMBAH";
            this.tambah.ThemeName = "TelerikMetroTouch";
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(779, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(90, 55);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // pesanResponse
            // 
            this.pesanResponse.Location = new System.Drawing.Point(24, 275);
            this.pesanResponse.Name = "pesanResponse";
            this.pesanResponse.ReadOnly = true;
            this.pesanResponse.Size = new System.Drawing.Size(277, 46);
            this.pesanResponse.TabIndex = 6;
            this.pesanResponse.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Untuk Tambah Data\r\nID Tidak Perlu Di Isi\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "PESAN RESPON SERVER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCKelola
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCKelola";
            this.Size = new System.Drawing.Size(890, 458);
            this.Load += new System.EventHandler(this.UCKelola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hapus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton hapus;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadButton edit;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadButton tambah;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox harga;
        private MetroFramework.Controls.MetroTextBox tujuan;
        private MetroFramework.Controls.MetroTextBox idTiket;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox pesanResponse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
