namespace TestUiDemo
{
    partial class FormLogin
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.crystalDarkTheme2 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.signIn = new Telerik.WinControls.UI.RadButton();
            this.exit = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_login = new MetroFramework.Controls.MetroTextBox();
            this.pass_login = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.solusi1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pendaftaran = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(36, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(165, 32);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "ADMIN PAGE";
            this.radLabel3.ThemeName = "CrystalDark";
            // 
            // signIn
            // 
            this.signIn.AutoSize = true;
            this.signIn.BackColor = System.Drawing.Color.Transparent;
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.ForeColor = System.Drawing.Color.Black;
            this.signIn.Location = new System.Drawing.Point(86, 270);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(63, 28);
            this.signIn.TabIndex = 4;
            this.signIn.Text = "SIGN IN";
            this.signIn.ThemeName = "CrystalDark";
            this.signIn.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(86, 378);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(68, 24);
            this.exit.TabIndex = 5;
            this.exit.Text = "EXIT";
            this.exit.ThemeName = "CrystalDark";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.Color.Black;
            this.radLabel4.Location = new System.Drawing.Point(77, 59);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(77, 28);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Sign In";
            this.radLabel4.ThemeName = "CrystalDark";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestUiDemo.Properties.Resources.img_311846;
            this.pictureBox1.Location = new System.Drawing.Point(65, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // user_login
            // 
            // 
            // 
            // 
            this.user_login.CustomButton.Image = null;
            this.user_login.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.user_login.CustomButton.Name = "";
            this.user_login.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.user_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_login.CustomButton.TabIndex = 1;
            this.user_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_login.CustomButton.UseSelectable = true;
            this.user_login.CustomButton.Visible = false;
            this.user_login.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.user_login.Icon = global::TestUiDemo.Properties.Resources._19_1User_512;
            this.user_login.Lines = new string[0];
            this.user_login.Location = new System.Drawing.Point(34, 198);
            this.user_login.MaxLength = 32767;
            this.user_login.Name = "user_login";
            this.user_login.PasswordChar = '\0';
            //this.user_login.PromptText = "Username";
            this.user_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_login.SelectedText = "";
            this.user_login.SelectionLength = 0;
            this.user_login.SelectionStart = 0;
            this.user_login.ShortcutsEnabled = true;
            this.user_login.ShowClearButton = true;
            this.user_login.Size = new System.Drawing.Size(199, 30);
            this.user_login.TabIndex = 6;
            this.user_login.UseSelectable = true;
            this.user_login.WaterMark = "Username";
            this.user_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pass_login
            // 
            // 
            // 
            // 
            this.pass_login.CustomButton.Image = null;
            this.pass_login.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.pass_login.CustomButton.Name = "";
            this.pass_login.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.pass_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass_login.CustomButton.TabIndex = 1;
            this.pass_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass_login.CustomButton.UseSelectable = true;
            this.pass_login.CustomButton.Visible = false;
            this.pass_login.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.pass_login.Icon = global::TestUiDemo.Properties.Resources.access_512;
            this.pass_login.Lines = new string[0];
            this.pass_login.Location = new System.Drawing.Point(34, 234);
            this.pass_login.MaxLength = 32767;
            this.pass_login.Name = "pass_login";
            this.pass_login.PasswordChar = '*';
            this.pass_login.PromptText = "Password";
            this.pass_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass_login.SelectedText = "";
            this.pass_login.SelectionLength = 0;
            this.pass_login.SelectionStart = 0;
            this.pass_login.ShortcutsEnabled = true;
            this.pass_login.ShowClearButton = true;
            this.pass_login.Size = new System.Drawing.Size(199, 30);
            this.pass_login.TabIndex = 7;
            this.pass_login.UseSelectable = true;
            this.pass_login.WaterMark = "Password";
            this.pass_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tidak dapat Sign In ?";
            // 
            // solusi1
            // 
            this.solusi1.AutoSize = true;
            this.solusi1.Location = new System.Drawing.Point(115, 8);
            this.solusi1.Name = "solusi1";
            this.solusi1.Size = new System.Drawing.Size(65, 13);
            this.solusi1.TabIndex = 10;
            this.solusi1.TabStop = true;
            this.solusi1.Text = "KLIK DISINI";
            this.solusi1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.solusi1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestUiDemo.Properties.Resources._19_1User_512;
            this.pictureBox2.Location = new System.Drawing.Point(5, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TestUiDemo.Properties.Resources.access_512;
            this.pictureBox3.Location = new System.Drawing.Point(5, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Belum Terdaftar ?";
            // 
            // pendaftaran
            // 
            this.pendaftaran.AutoSize = true;
            this.pendaftaran.Location = new System.Drawing.Point(96, 31);
            this.pendaftaran.Name = "pendaftaran";
            this.pendaftaran.Size = new System.Drawing.Size(118, 13);
            this.pendaftaran.TabIndex = 10;
            this.pendaftaran.TabStop = true;
            this.pendaftaran.Text = "DAFTAR SEKARANG !";
            this.pendaftaran.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pendaftaran_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.solusi1);
            this.panel1.Controls.Add(this.pendaftaran);
            this.panel1.Location = new System.Drawing.Point(5, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 54);
            this.panel1.TabIndex = 13;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(8, 11);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(23, 33);
            this.panelContainer.TabIndex = 14;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(245, 414);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.user_login);
            this.Controls.Add(this.pass_login);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.radLabel3);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN LOGIN";
            this.ThemeName = "Office2013Dark";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton signIn;
        private Telerik.WinControls.UI.RadButton exit;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private MetroFramework.Controls.MetroTextBox user_login;
        private MetroFramework.Controls.MetroTextBox pass_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel solusi1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel pendaftaran;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
    }
}
