using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace TestUiDemo
{
    public partial class UCDaftarAdmin : UserControl
    {
        public UCDaftarAdmin()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && namaLengkap.Text == "" && password.Text == "" && valid_password.Text == "")
            {
                MessageBox.Show("LENGKAPI SEMUA DATA");
            }
            else
            {
                if (password.Text == valid_password.Text)
                {
                    try
                    {
                        var client = new RestClient("http://localhost/web_sister/REST_API/api/admin");
                        var request = new RestRequest(Method.POST);
                        //request.AddParameter("undefined", "userId=" + username.Text + "&nama=" + namaLengkap.Text + "&password=" + valid_password.Text, ParameterType.RequestBody);
                        request.AddParameter("userId", username.Text);
                        request.AddParameter("password", password.Text);
                        request.AddParameter("nama", namaLengkap.Text);
                        var response = client.Execute(request);
                        var hasil = response.Content;
                        JObject obj = JObject.Parse(hasil);
                        bool status = (bool)obj.SelectToken("status");
                        MessageBox.Show(status.ToString() + "\nBERHASIL MENAMBAH DATA");
                        FormLogin a = new FormLogin();
                        a.Show();
                        this.Hide();
                    }
                    catch (Exception eror)
                    {
                        MessageBox.Show(eror.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("PASSWORD TIDAK SAMA !");
                }
            }
        }
    }
}
