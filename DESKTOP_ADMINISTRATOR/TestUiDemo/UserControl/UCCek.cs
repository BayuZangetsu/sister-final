using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using JsonPath;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace TestUiDemo
{
    public partial class UCCek : UserControl
    {
        public UCCek()
        {
            InitializeComponent();
        }
        public void resettext()
        {
            cari_idtransaksi.Clear();
            nik.Clear();
            nama.Clear();
            alamat.Clear();
            sex.Clear();
            idtiket.Clear();
            tujuan.Clear();
            harga.Clear();
            idCust.Clear();
            status.Clear();
        }
        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (cari_idtransaksi.Text == "")
            {
                MessageBox.Show("MASUKAN ID YANG AKAN DICARI !", "PERINGATAN", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //cari transaksi
                    var client = new RestClient("http://localhost/web_sister/REST_API/api/transaksi");
                    var request = new RestRequest(Method.GET);
                    request.AddParameter("idTransaksi", cari_idtransaksi.Text);
                    IRestResponse response = client.Execute(request);
                    var parsing = response.Content;
                    JObject obj = JObject.Parse(parsing);
                    bool statusKoneksi = (bool)obj.SelectToken("status");
                    if (statusKoneksi == false)
                    {
                        MessageBox.Show("PERIKSA KEMBALI DATA ANDA !", "KESALAHAN");
                    }
                    else
                    {
                        DateTime data_tanggal = (DateTime)obj.SelectToken("data[0].tglTransaksi");
                        string data_idCustomer = (string)obj.SelectToken("data[0].idCustomer");
                        string data_idTiket = (string)obj.SelectToken("data[0].idTiket");
                        string statustransaksi = (string)obj.SelectToken("data[0].status");
                        if (statustransaksi == "1")
                        {
                            status.Text = "SUDAH DIVALIDASI";
                        }
                        else
                        {
                            status.Text = "BELUM DIVALIDASI";
                        }
                        idCust.Text = data_idCustomer;
                        idtiket.Text = data_idTiket;
                        tglTransaksi.Value = data_tanggal;
                        waktu.Value = data_tanggal;

                        //cari biodata customer
                        var client1 = new RestClient("http://localhost/web_sister/REST_API/api/pelanggan");
                        var request1 = new RestRequest(Method.GET);
                        request1.AddParameter("idCustomer", idCust.Text);
                        IRestResponse response1 = client1.Execute(request1);
                        var parsing1 = response1.Content;
                        JObject o = JObject.Parse(parsing1);
                        string data_nik = (string)o.SelectToken("data[0].nik");
                        string data_nama = (string)o.SelectToken("data[0].namaCustomer");
                        string data_sex = (string)o.SelectToken("data[0].sex");
                        string data_alamat = (string)o.SelectToken("data[0].alamatCustomer");
                        nik.Text = data_nik;
                        nama.Text = data_nama;
                        sex.Text = data_sex;
                        alamat.Text = data_alamat;

                        //cari data tiket
                        string idTik = data_idTiket;
                        var client2 = new RestClient("http://localhost/web_sister/REST_API/api/tiket");
                        var request2 = new RestRequest(Method.GET);
                        request2.AddParameter("idTiket", idTik);
                        IRestResponse response2 = client2.Execute(request2);
                        var parsing2 = response2.Content;
                        JObject ob = JObject.Parse(parsing2);
                        string data_id = (string)ob.SelectToken("data[0].idTiket");
                        string data_tujuan = (string)ob.SelectToken("data[0].tujuan");
                        string data_harga = (string)ob.SelectToken("data[0].harga");
                        idtiket.Text = data_id;
                        tujuan.Text = data_tujuan;
                        harga.Text = data_harga;
                    }
                }
                catch (Exception eror)
                {
                    MessageBox.Show(eror.ToString() + "\n\nPERIKSA KEMBALI ID TRANSAKSI ANDA!");
                }
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            resettext();
        }
    }
}
