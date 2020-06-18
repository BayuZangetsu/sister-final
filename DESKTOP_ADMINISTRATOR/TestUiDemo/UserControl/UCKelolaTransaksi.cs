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
using Newtonsoft.Json;

namespace TestUiDemo
{
    public partial class UCKelolaTransaksi : UserControl
    {
        public UCKelolaTransaksi()
        {
            InitializeComponent();
        }
        public void getData()
        {
            try
            {
                dgv.Rows.Clear();
                var client = new RestClient("http://localhost/web_sister/REST_API/api/transaksi");
                var request = new RestRequest(Method.GET);
                var response = client.Execute(request);
                var dump = response.Content;
                //var arr = JsonConvert.DeserializeObject<JArray>(dump);
                JObject obj = JObject.Parse(dump);
                JArray jarr = (JArray)obj["data"];
                //foreach(var item in jarr)
                //{
                //  string idTrans = (string)item.SelectToken("idTransaksi");
                //idTransaksi.ValueType = idTrans.GetType();

                //}
                dgv.DataSource = jarr;
                FormUtama.Instance.labeljudul.Visible = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "EROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UCKelolaTransaksi_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string id = idtransaksi.Text;
            var client = new RestClient("http://localhost/web_sister/REST_API/api/transaksi");
            var request = new RestRequest(Method.DELETE);
            request.AddParameter("undefined", "idTransaksi="+id, ParameterType.RequestBody);
            var response = client.Execute(request);
            JObject dump = JObject.Parse(response.Content);
            MessageBox.Show((string)dump.SelectToken("pesan"));
            getData();
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                idtransaksi.Text = dgv.SelectedRows[0].Cells[0].Value + string.Empty;
                tgltransaksi.Text = dgv.SelectedRows[0].Cells[1].Value + string.Empty;
                idcustomer.Text = dgv.SelectedRows[0].Cells[2].Value + string.Empty;
                idtiket.Text = dgv.SelectedRows[0].Cells[3].Value + string.Empty;
                status.Text = dgv.SelectedRows[0].Cells[4].Value + string.Empty;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
