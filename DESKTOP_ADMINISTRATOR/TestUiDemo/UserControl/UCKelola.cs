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
    public partial class UCKelola : UserControl
    {
        public UCKelola()
        {
            InitializeComponent();
        }
        private JArray getData()
        {
            
            var client = new RestClient("http://localhost/web_sister/REST_API/api/tiket");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            JObject obj = JObject.Parse(response);
            JArray array = (JArray)obj["data"];
            string status = (string)obj.SelectToken("status");
            //jarr = array;
            //string[] r = array.Select(jv => (string)jv).ToArray();
            //var data = array;
            //a = Convert.ToString(data);
            //a = r.ToString();
            dgv.DataSource = array;
            return array;
        }
        private void insertData(string a,int b)
        {
            try
            {
                var client = new RestClient("http://localhost/web_sister/REST_API/api/tiket");
                var request = new RestRequest(Method.POST);
                request.AddParameter("tujuan", a);
                request.AddParameter("harga", b);
                var response = client.Execute(request).Content;
                JObject obj = JObject.Parse(response);
                string pesan = (string)obj.SelectToken("pesan");
                //MessageBox.Show(response.ToString());
                pesanResponse.Text=pesan;
            }
            catch(Exception eror)
            {
                MessageBox.Show(eror.ToString());
            }
        }
        private void deleteData(int a)
        {
            try
            {
                var client = new RestClient("http://localhost/web_sister/REST_API/api/tiket");
                var request = new RestRequest(Method.DELETE);
                request.AddParameter("undefined","idTiket="+a,ParameterType.RequestBody);
                var response = client.Execute(request).Content;
                JObject obj = JObject.Parse(response);
                string pesan = (string)obj.SelectToken("pesan");
                //MessageBox.Show(response.ToString());
                pesanResponse.Text = pesan;
            }
            catch (Exception eror)
            {
                MessageBox.Show(eror.ToString());
            }
        }
        private void updateData(int a,string b,int c)
        {
            try
            {
                var client = new RestClient("http://localhost/web_sister/REST_API/api/tiket");
                var request = new RestRequest(Method.PUT);
                request.AddParameter("undefined", "idTiket=" + a+"&tujuan="+b+"&harga="+c, ParameterType.RequestBody);
                var response = client.Execute(request).Content;
                JObject obj = JObject.Parse(response);
                string pesan = (string)obj.SelectToken("pesan");
                //MessageBox.Show(response.ToString());
                pesanResponse.Text = pesan;
            }
            catch (Exception eror)
            {
                MessageBox.Show(eror.ToString());
            }
        }
        private void UCKelola_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTiket.Text);
            string tujuanTiket = tujuan.Text;
            int hargaTiket = int.Parse(harga.Text);
            updateData(id, tujuanTiket, hargaTiket);
            getData();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            int id =int.Parse(idTiket.Text);
            deleteData(id);
            getData();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            String tujuanTiket = tujuan.Text;
            int hargaTiket =int.Parse( harga.Text);
            insertData(tujuanTiket, hargaTiket);
            getData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                idTiket.Text = dgv.SelectedRows[0].Cells[0].Value + string.Empty;
                tujuan.Text = dgv.SelectedRows[0].Cells[1].Value + string.Empty;
                harga.Text = dgv.SelectedRows[0].Cells[2].Value + string.Empty;
            }
        }
    }
}
