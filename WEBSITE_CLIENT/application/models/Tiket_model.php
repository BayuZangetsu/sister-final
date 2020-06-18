<?php
use GuzzleHttp\Client;

    class Tiket_model extends CI_Model{
        public function tambahData()
        {
            $data = [
                "nik" => $this->input->post('nik', true),
                "namaCustomer" => $this->input->post('namaCustomer', true),
                "sex" => $this->input->post('sex', true),
                "alamatCustomer" => $this->input->post('alamatCustomer', true)
            ];

            $datadua = [
                "tujuan" => $this->input->post('tujuan', true),
                "harga" => $this->input->post('harga', true)
            ];

            $datatiga = [
                "idCustomer" => $this->input->post('idCustomer', true),
                "idTiket" => $this->input->post('idTiket', true),
                "status" => $this->input->post('status', true)
            ];

            //$this->db->insert('customer', $data);
            $client = new Client();

            $response = $client->request('POST', 'http://localhost/web_sister/REST_API/api/pelanggan', [
                'form_params' => $data
            ]);

            $result = json_decode($response->getBody()->getContents(), true);

            return $result;

            // //$this->db->insert('tiket', $datadua);
            // $client = new Client();

            // $response = $client->request('POST', 'http://localhost/web_sister/REST_API/api/tiket', [
            //     'form_params' => $datadua
            // ]);

            // $result = json_decode($response->getBody()->getContents(), true);

            // return $result;

            $this->db->insert('transaksi', $datatiga);
            //$client = new Client();

            //$response = $client->request('POST', 'http://localhost/web_sister/REST_API/api/transaksi', [
            //    'form_params' => $datatiga
            //]);

            //$result = json_decode($response->getBody()->getContents(), true);

            //return $result;
        }

        public function dapatCus()
        {
            $this->db->select("MAX(idCustomer)+1 AS idcus");
            $this->db->from("customer");
            $query = $this->db->get();
            return
            $query->row()->idcus;
        }

        public function tiket_fetch()
        {
            $this->db->order_by('idTiket', 'ASC');
            $query = $this->db->get('tiket');
            return $query->result();
        }


        public function tikettujuharga(){
            $this->db->order_by('idTiket', 'ASC');
            $query = $this->db->get('tiket');
            return $query->result();
        }

        public function dapatID()
        {
            //return $this->db->get('transaksi')->result_array();
            $client = new Client();

            $response = $client->request('GET', 'http://localhost/web_sister/REST_API/api/transaksi');

            $result = json_decode($response->getBody()->getContents(), true);

            return $result['data'];
        }

        public function infoID($id)
        {
            //return $this->db->get_where('transaksi', ['idTransaksi' => $id])->row_array();
            $client = new Client();

            $response = $client->request('GET', 'http://localhost/web_sister/REST_API/api/transaksi', [
                'query' => [
                    'idTransaksi' => $id
                ]
            ]);

            $result = json_decode($response->getBody()->getContents(), true);

            return $result['data'][0];
        }

        public function cariID()
        {
            $keyword = $this->input->post('keyword', true);
            $this->db->like('idTransaksi', $keyword);
            return $this->db->get('transaksi')->result_array();
        }

        public function idtrans()
        {
            $this->db->select("MAX(idTransaksi) AS idtrans");
            $this->db->from("transaksi");
            $query = $this->db->get();
            return
            $query->row()->idtrans;
        }
        public function dapatcus2($id)
        {
            $this->db->select("MAX(idCustomer) AS idcus");
            $this->db->from("customer");
            $id = $this->db->get();
            return
            $id->row()->idcus;
        }

    }