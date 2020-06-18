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

            //$this->db->insert('tiket', $datadua);
            $client = new Client();

            $response = $client->request('POST', 'http://localhost/web_sister/REST_API/api/tiket', [
                 'form_params' => $datadua
             ]);

             $result = json_decode($response->getBody()->getContents(), true);

             return $result;

            //$this->db->insert('transaksi', $datatiga);
            //get idTiket
            $client = new Client();

            $response = $client->request('POST', 'http://localhost/web_sister/REST_API/api/transaksi', [
                'form_params' => $datatiga
            ]);

            $result = json_decode($response->getBody()->getContents(), true);

            return $result;
        }


        public function tiket_fetch()
        {
            $this->db->limit(12);
            $this->db->order_by('idTiket', 'ASC');
            $query = $this->db->get('tiket');
            return $query->result();
        }
        
        public function ternyata()
        {
            $this->db->select("MAX(idCustomer)+1 AS idcus");
            $this->db->from("customer");
            $query = $this->db->get();
            return
            $query->row()->idcus;
        }
        
        public function ternyatadua()
        {
            // $data=$this->db->get('idTiket','tiket');
            // $client = new Client();

            // $response = $client->request('GET', 'http://localhost/web_sister/REST_API/api/tiket', [
            //     'tujuan' => $data['tiket']
            // ]);

            // $result = json_decode($response->getBody()->getContents(), true);

            // return $result;
            $this->db->select("MAX(idTiket)+1 AS idtkt");
            $this->db->from("tiket");
            $query = $this->db->get();
            return
            $query->row()->idtkt;
        }
        
        public function idtrans()
        {
            $this->db->select("MAX(idTransaksi)+1 AS idtrans");
            $this->db->from("transaksi");
            $query = $this->db->get();
            return
            $query->row()->idtrans;
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
    }