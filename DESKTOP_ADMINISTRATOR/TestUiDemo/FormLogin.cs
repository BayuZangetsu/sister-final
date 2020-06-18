using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RestSharp;
using Newtonsoft.Json.Linq;
using Telerik.WinControls.Enumerations;

namespace TestUiDemo
{
    public partial class FormLogin : Telerik.WinControls.UI.ShapedForm
    {
        static FormLogin _obj;
        public FormLogin()
        {
            InitializeComponent();
        }
        public static FormLogin Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormLogin();
                }
                return _obj;
            }
        }      
        /*
        static String connectionString = "datasource = 127.0.0.1;port=3306;username=root;password=;database=penjualan;";
        static MySqlConnection db = new MySqlConnection(connectionString);
        MySqlDataReader reader;*/
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("http://localhost/web_sister/REST_API/api/admin?userId=" + user_login.Text);
                var request = new RestRequest(Method.GET);
                var response = client.Execute(request);
                var dump_data = response.Content;
                JObject objek = JObject.Parse(dump_data);
                bool status = (bool)objek.SelectToken("status");
                string user = (string)objek.SelectToken("data[0].userId");
                string password = (string)objek.SelectToken("data[0].password");
                string nama = (string)objek.SelectToken("data[0].nama");
                if (status == false)
                {
                    MessageBox.Show((string)objek.SelectToken("pesan") + "\nPERIKSA KEMBALI DATA ANDA");
                }
                else
                {
                    if (pass_login.Text != password)
                    {
                        MessageBox.Show("PASSWORD YANG ANDA MASUKAN SALAH !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Selamat Datang " + nama + " ^_^", "LOGIN BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        FormUtama formutama = new FormUtama();
                        formutama.Show();
                        formutama.BringToFront();
                        this.Hide();
                    }
                }
            }
            catch(Exception eror)
            {
                MessageBox.Show(eror.ToString());
            }
        }
            /*
            db.Open();
            String query = "SELECT * FROM admin WHERE userId="+user_login.Text+";";
            MySqlCommand cmd = new MySqlCommand(query, db);
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                if (pass_login.Text == reader.GetString(1))
                {
                    MessageBox.Show("Selamat Datang " + reader.GetString(0) + " ^_^", "LOGIN BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form1 formutama = new Form1();
                    formutama.Show();
                    formutama.BringToFront();
                    this.Hide();
                }
                else
                {
                    DialogResult a = new DialogResult();
                    a = MessageBox.Show("USER/PASSWORD YANG ANDA MASUKAN SALAH !", "PERINGATAN", MessageBoxButtons.RetryCancel);
                    if (a == DialogResult.Retry)
                    {
                        this.ResetText();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch(Exception kesalahan)
            {
                MessageBox.Show("Eror" + kesalahan.ToString());
            }
            db.Close();*/
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void solusi1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hubungi Bagian IT untuk RESET Akun Anda");
        }

        private void pendaftaran_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelContainer.Dock = DockStyle.Fill;
            UCDaftarAdmin uda = new UCDaftarAdmin();
            panelContainer.Controls.Add(uda);
            uda.Dock = DockStyle.Fill;
            panelContainer.BringToFront();
            /*if (!FormLogin.Instance.panelContainer.Controls.ContainsKey("UCDaftarAdmin"))
            {
                UCDaftarAdmin uda = new UCDaftarAdmin();
                uda.Dock = DockStyle.Fill;
                FormLogin.Instance.panelContainer.Controls.Add(uda);
            }
            FormLogin.Instance.panelContainer.Controls["UCDaftarAdmin"].BringToFront();*/
        }
    }
}
