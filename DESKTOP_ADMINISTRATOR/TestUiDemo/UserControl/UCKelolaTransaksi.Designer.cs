namespace TestUiDemo
{
    partial class UCKelolaTransaksi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new MetroFramework.Controls.MetroTextBox();
            this.tgltransaksi = new MetroFramework.Controls.MetroTextBox();
            this.idtiket = new MetroFramework.Controls.MetroTextBox();
            this.idcustomer = new MetroFramework.Controls.MetroTextBox();
            this.idtransaksi = new MetroFramework.Controls.MetroTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.refresh = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAJEMEN TRANSAKSI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Controls.Add(this.metroButton1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.status);
            this.panel3.Controls.Add(this.tgltransaksi);
            this.panel3.Controls.Add(this.idtiket);
            this.panel3.Controls.Add(this.idcustomer);
            this.panel3.Controls.Add(this.idtransaksi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(641, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 417);
            this.panel3.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton1.BackColor = System.Drawing.Color.Red;
            this.metroButton1.Location = new System.Drawing.Point(81, 219);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(78, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "HAPUS";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TANGGAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID TIKET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID CUST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID TRANS";
            // 
            // status
            // 
            // 
            // 
            // 
            this.status.CustomButton.Image = null;
            this.status.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.status.CustomButton.Name = "";
            this.status.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.status.CustomButton.TabIndex = 1;
            this.status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.status.CustomButton.UseSelectable = true;
            this.status.CustomButton.Visible = false;
            this.status.Lines = new string[0];
            this.status.Location = new System.Drawing.Point(81, 160);
            this.status.MaxLength = 32767;
            this.status.Name = "status";
            this.status.PasswordChar = '\0';
            this.status.PromptText = "STATUS";
            this.status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.status.SelectedText = "";
            this.status.SelectionLength = 0;
            this.status.SelectionStart = 0;
            this.status.ShortcutsEnabled = true;
            this.status.Size = new System.Drawing.Size(152, 23);
            this.status.TabIndex = 3;
            this.status.UseSelectable = true;
            this.status.WaterMark = "STATUS";
            this.status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tgltransaksi
            // 
            // 
            // 
            // 
            this.tgltransaksi.CustomButton.Image = null;
            this.tgltransaksi.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.tgltransaksi.CustomButton.Name = "";
            this.tgltransaksi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tgltransaksi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tgltransaksi.CustomButton.TabIndex = 1;
            this.tgltransaksi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tgltransaksi.CustomButton.UseSelectable = true;
            this.tgltransaksi.CustomButton.Visible = false;
            this.tgltransaksi.Lines = new string[0];
            this.tgltransaksi.Location = new System.Drawing.Point(81, 131);
            this.tgltransaksi.MaxLength = 32767;
            this.tgltransaksi.Name = "tgltransaksi";
            this.tgltransaksi.PasswordChar = '\0';
            this.tgltransaksi.PromptText = "TANGGAL";
            this.tgltransaksi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tgltransaksi.SelectedText = "";
            this.tgltransaksi.SelectionLength = 0;
            this.tgltransaksi.SelectionStart = 0;
            this.tgltransaksi.ShortcutsEnabled = true;
            this.tgltransaksi.Size = new System.Drawing.Size(152, 23);
            this.tgltransaksi.TabIndex = 3;
            this.tgltransaksi.UseSelectable = true;
            this.tgltransaksi.WaterMark = "TANGGAL";
            this.tgltransaksi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tgltransaksi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idtiket
            // 
            // 
            // 
            // 
            this.idtiket.CustomButton.Image = null;
            this.idtiket.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.idtiket.CustomButton.Name = "";
            this.idtiket.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idtiket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idtiket.CustomButton.TabIndex = 1;
            this.idtiket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idtiket.CustomButton.UseSelectable = true;
            this.idtiket.CustomButton.Visible = false;
            this.idtiket.Lines = new string[0];
            this.idtiket.Location = new System.Drawing.Point(81, 102);
            this.idtiket.MaxLength = 32767;
            this.idtiket.Name = "idtiket";
            this.idtiket.PasswordChar = '\0';
            this.idtiket.PromptText = "ID TIKET";
            this.idtiket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idtiket.SelectedText = "";
            this.idtiket.SelectionLength = 0;
            this.idtiket.SelectionStart = 0;
            this.idtiket.ShortcutsEnabled = true;
            this.idtiket.Size = new System.Drawing.Size(152, 23);
            this.idtiket.TabIndex = 3;
            this.idtiket.UseSelectable = true;
            this.idtiket.WaterMark = "ID TIKET";
            this.idtiket.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idtiket.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idcustomer
            // 
            // 
            // 
            // 
            this.idcustomer.CustomButton.Image = null;
            this.idcustomer.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.idcustomer.CustomButton.Name = "";
            this.idcustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idcustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idcustomer.CustomButton.TabIndex = 1;
            this.idcustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idcustomer.CustomButton.UseSelectable = true;
            this.idcustomer.CustomButton.Visible = false;
            this.idcustomer.Lines = new string[0];
            this.idcustomer.Location = new System.Drawing.Point(81, 73);
            this.idcustomer.MaxLength = 32767;
            this.idcustomer.Name = "idcustomer";
            this.idcustomer.PasswordChar = '\0';
            this.idcustomer.PromptText = "ID CUSTOMER";
            this.idcustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idcustomer.SelectedText = "";
            this.idcustomer.SelectionLength = 0;
            this.idcustomer.SelectionStart = 0;
            this.idcustomer.ShortcutsEnabled = true;
            this.idcustomer.Size = new System.Drawing.Size(152, 23);
            this.idcustomer.TabIndex = 3;
            this.idcustomer.UseSelectable = true;
            this.idcustomer.WaterMark = "ID CUSTOMER";
            this.idcustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idcustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idtransaksi
            // 
            // 
            // 
            // 
            this.idtransaksi.CustomButton.Image = null;
            this.idtransaksi.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.idtransaksi.CustomButton.Name = "";
            this.idtransaksi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idtransaksi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idtransaksi.CustomButton.TabIndex = 1;
            this.idtransaksi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idtransaksi.CustomButton.UseSelectable = true;
            this.idtransaksi.CustomButton.Visible = false;
            this.idtransaksi.Lines = new string[0];
            this.idtransaksi.Location = new System.Drawing.Point(81, 33);
            this.idtransaksi.MaxLength = 32767;
            this.idtransaksi.Name = "idtransaksi";
            this.idtransaksi.PasswordChar = '\0';
            this.idtransaksi.PromptText = "ID TRANSAKSI";
            this.idtransaksi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idtransaksi.SelectedText = "";
            this.idtransaksi.SelectionLength = 0;
            this.idtransaksi.SelectionStart = 0;
            this.idtransaksi.ShortcutsEnabled = true;
            this.idtransaksi.Size = new System.Drawing.Size(152, 23);
            this.idtransaksi.TabIndex = 2;
            this.idtransaksi.UseSelectable = true;
            this.idtransaksi.WaterMark = "ID TRANSAKSI";
            this.idtransaksi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idtransaksi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.dgv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 417);
            this.panel4.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(641, 417);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // refresh
            // 
            this.refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refresh.BackColor = System.Drawing.Color.Red;
            this.refresh.Location = new System.Drawing.Point(81, 261);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(78, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Refresh";
            this.refresh.UseSelectable = true;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // UCKelolaTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UCKelolaTransaksi";
            this.Size = new System.Drawing.Size(890, 458);
            this.Load += new System.EventHandler(this.UCKelolaTransaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox status;
        private MetroFramework.Controls.MetroTextBox tgltransaksi;
        private MetroFramework.Controls.MetroTextBox idtiket;
        private MetroFramework.Controls.MetroTextBox idcustomer;
        private MetroFramework.Controls.MetroTextBox idtransaksi;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv;
        private MetroFramework.Controls.MetroButton refresh;
    }
}
