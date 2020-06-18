using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;

namespace TestUiDemo
{
    public partial class UCRegistrasi : UserControl
    {
        public UCRegistrasi()
        {
            InitializeComponent();
        }
        public void getDataTiket()
        {
            comboTujuan.ResetText();
            comboTujuan.Items.Clear();
            var client = new RestClient("http://localhost/web_sister/REST_API/api/tiket");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            var result = response.Content;
            JObject ob = JObject.Parse(result);
            JArray jarr = (JArray)ob["data"];
            foreach (var item in jarr)
            {
                string items = (string)item.SelectToken("tujuan");
                comboTujuan.Items.Add(items);
            }
        }
        public void insertCustomer(string a, string b, string c,string d)
        {
            var client = new RestClient("http://localhost/web_sister/REST_API/api/pelanggan");
            var request = new RestRequest(Method.POST);
            /*request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("content-length", "61");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Host", "localhost");
            request.AddHeader("Postman-Token", "c38e4d30-3e73-45ad-a691-f938ed3bf5af,534480ba-e13a-49d5-98d7-9c52071d2503");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", //"/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.13.0");*/
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("undefined", "nik=" + a + "&namaCustomer=" + b +
                "&sex=" + c + "&alamatCustomer=" + d, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            HttpStatusCode statuscode = response.StatusCode;

        }
        private void UCRegistrasi_Load(object sender, EventArgs e)
        {
            getDataTiket();   
        }
        private void resettext()
        {
            nama.Clear();
            nik.Clear();
            alamat.Clear();
            comboSex.ResetText();
            idCust.Clear();
            comboTujuan.ResetText();
            idTrans.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nama.Text == "" && nik.Text == ""&& alamat.Text == "" && comboSex.Text == "")
            {
                MessageBox.Show("LENGKAPI SEMUA DATA", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var client = new RestClient("http://localhost/web_sister/REST_API/api/pelanggan");
            var request = new RestRequest(Method.POST);
            /*request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("content-length", "61");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Host", "localhost");
            request.AddHeader("Postman-Token", "c38e4d30-3e73-45ad-a691-f938ed3bf5af,534480ba-e13a-49d5-98d7-9c52071d2503");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", //"/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.13.0");*/
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("undefined", "nik="+nik.Text+"&namaCustomer="+nama.Text+
                "&sex="+comboSex.SelectedItem+"&alamatCustomer="+alamat.Text, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            HttpStatusCode statuscode = response.StatusCode;
            
            //coba get data
            
            var client2 = new RestClient("http://localhost/web_sister/REST_API/api/pelanggan");
            var request2 = new RestRequest(Method.GET);
            request2.AddParameter("nik", nik.Text);
            request2.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var exec = client.Execute(request2);
            var result = exec.Content;
            JObject objek = JObject.Parse(result);
            string idCustomer=(string)objek.SelectToken("data[0].idCustomer");
            idCust.Text = idCustomer;
            //JObject ob = JObject.Parse(feedback);
            //string data_id = (string)ob.SelectToken("data[0].idCustomer");
            int numericStatuscode = (int)statuscode;
            if(numericStatuscode == 201)
            {
                MessageBox.Show("Pendaftaran BIODATA berhasil"
                    +"\nID ANDA ADALAH = "+idCustomer+"\nHARAP CATAT ID ANDA !\nsilahkan ke tahap selanjutnya", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox2.Visible = true;
            }
            else
            {
                MessageBox.Show("HTTP STATUS CODE = " + numericStatuscode.ToString() + "\n\nPeriksa Kembali Data Anda 1");
            }
        }

        private void booking_Click(object sender, EventArgs e)
        {
            var client=new RestClient("http://localhost/web_sister/REST_API/api/tiket");
            var request = new RestRequest(Method.GET);
            request.AddParameter("tujuan", comboTujuan.SelectedItem);
            var result = client.Execute(request);
            var content = result.Content;
            JObject obj = JObject.Parse(content);
            DialogResult tombol=
            MessageBox.Show("Tiket Yang Anda Pilih\n Tujuan = "+(string)obj.SelectToken("data[0].tujuan")+
                "\nHarga = "+(string)obj.SelectToken("data[0].harga")+"\n Lanjutkan Booking ?","KONFIRMASI BOOKING",
                MessageBoxButtons.OKCancel);
            if (tombol == DialogResult.OK)
            {
                try {
                    var clientT = new RestClient("http://localhost/web_sister/REST_API/api/transaksi");
                    var requestT = new RestRequest(Method.POST);
                    requestT.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    requestT.AddParameter("undefined","idCustomer="+idCust.Text+ 
                        "&idTiket="+(string)obj.SelectToken("data[0].idTiket")+
                        "&status=0",ParameterType.RequestBody);
                    IRestResponse response = clientT.Execute(requestT);
                    MessageBox.Show("Data Berhasil Terinput, Silahkan Melakukan Pembayaran Untuk Memvalidasi Pemesanan Anda\n"
                        +"harap catat ID Tiket Anda yang muncul di bawah Untuk Validasi !");
                    var req2 = new RestRequest(Method.GET);
                    req2.AddParameter("idCustomer", idCust.Text);
                    var execute = clientT.Execute(req2);
                    var hasil = execute.Content;
                    JObject objek = JObject.Parse(hasil);
                    idTrans.Text = (string)objek.SelectToken("data[0].idTransaksi");
                }
                catch(Exception eror) { MessageBox.Show(eror.ToString()); }
                
            }
            else
            {//jika transaksi dibatalkan beri pilihan, pilih tiket lain atau tidak
                DialogResult batal=MessageBox.Show("Transaksi Dibatalkan !","BATALKAN",MessageBoxButtons.OK);
                if (batal == DialogResult.OK)
                {
                    DialogResult pesanlagi=MessageBox.Show("PESAN TIKET TUJUAN LAIN ?", "KONFIRMASI LAGI", MessageBoxButtons.YesNo);
                    if (pesanlagi == DialogResult.Yes)
                    {
                        //messagebox ini bakal nutup
                        //ulang dari awal
                    }
                    else //data customer dihapus
                    {
                        string id = idCust.Text;
                        try {
                            //MessageBox.Show(id);/*
                            var clientC = new RestClient("http://localhost/web_sister/REST_API/api/pelanggan");
                            var requestC = new RestRequest(id,Method.DELETE,DataFormat.Json);
                            //= resp => { resp.ContentType = "application/json"; };
                            //requestC.AddHeader("content-length", "13");
                            //requestC.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                            requestC.AddParameter("undefined","idCustomer="+id.ToString(),ParameterType.RequestBody);
                            var ex=clientC.Delete(requestC);
                            var ec = ex.Content;
                            JObject ja = JObject.Parse(ec);
                            string pesan = (string)ja.SelectToken("status");
                            MessageBox.Show("DATA CUSTOMER TELAH DIHAPUS DARI DATABASE\nStatus penghapusan ="+pesan);
                            resettext();
                        }
                        catch(Exception eror)
                        {
                            MessageBox.Show(eror.ToString());
                        }
                    }
                }

            }
        }


        private void change(object sender, EventArgs e)
        {
            /*
            
            var client = new RestClient("http://localhost/web_sister/REST_API/api/tiket");
            var request = new RestRequest(Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var exec = client.Execute(request);
            var result = exec.Content;
            //JObject ob = JObject.Parse(result);
            //JArray jarr = (JArray)ob["data"];
            var dobjek = JToken.Parse(result);
            var dataOb = dobjek.Children<JProperty>().FirstOrDefault(x => x.Name == "data").Value;
            foreach(var item in dataOb.Children())
            {
                var propertiItem = item.Children<JProperty>();
                var myElement = propertiItem.FirstOrDefault(x => x.Name == "harga");
                var dataElement = myElement.Value;
                harga.Text = dataElement.ToString();
            }
           
            */
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resettext();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataTiket();
        }
    }
}