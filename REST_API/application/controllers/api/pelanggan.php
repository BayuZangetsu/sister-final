<?php
use Restserver\Libraries\REST_Controller;

defined('BASEPATH') OR exit('No direct script access allowed');

require APPPATH . 'libraries/REST_Controller.php';

require APPPATH . 'libraries/Format.php';

class pelanggan extends REST_Controller{
    public function __construct()
    {
        parent::__construct();
        $this->load->model('Model_pelanggan','pelanggan');
    }
    public function index_get(){
        $id=$this->get('idCustomer');
        $nik=$this->get('nik');
        /*if($nama===null){
            $pelanggan=$this->pelanggan->getPelanggan();
        }
        else{
        }*/
        if($id===null && $nik===null){
            $pelanggan=$this->pelanggan->getPelanggan();
        }
        else if($id!==null && $nik===null){
            $pelanggan=$this->pelanggan->getPelanggan($id,$nik);
        }
        else if($id===null && $nik!==null){
            $pelanggan=$this->pelanggan->getPelanggan($id,$nik);
        }
        if($pelanggan){
            $this->response([
                'status' => true,
                'data'=>$pelanggan
            ], REST_Controller::HTTP_OK);
        }
        else{
            $this->response([
                'status'=>false,
                'pesan'=>'data not found !'
            ],REST_Controller::HTTP_NOT_FOUND);
        }
    }
    public function index_post()
    {
        $data=[
            'idCustomer'=>$this->post('idCustomer'|null),
            'nik'=>$this->post('nik'),
            'namaCustomer'=>$this->post('namaCustomer'),
            'sex'=>$this->post('sex'),
            'alamatCustomer'=>$this->post('alamatCustomer')
        ];
        if($this->pelanggan->createPelanggan($data)>0){
            $this->response([
                'status'=>true,
                'pesan'=>'BERHASIL MENAMBAH DATA'
            ],REST_Controller::HTTP_CREATED);
        }
        else{
            $this->response([
                'status'=>false,
                'pesan'=>'DATA TIDAK DAPAT DITAMBAHKAN'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
    }
    public function index_delete()
    {
        $id=$this->delete('idCustomer');
        if($id===null){
            $this->response([
                'status'=>false,
                'pesan'=>'MASUKAN ID YANG AKAN DIHAPUS !'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
        else
        {
            if($this->pelanggan->deletePelanggan($id)>0){
                $this->response([
                    'status'=>true,
                    'id'=>$id,
                    'pesan'=>'id terhapus'
                ],REST_Controller::HTTP_OK);
            }
            else{
                $this->response([
                    'status'=>false,
                    'pesan'=>'id tidak ada'
                ],REST_Controller::HTTP_NOT_FOUND);
            }
        }
    }
    public function index_put()
    {
        $id=$this->put('idCustomer');
        $data=[
            'nik'=>$this->put('nik'),
            'namaCustomer'=>$this->put('namaCustomer'),
            'sex'=>$this->post('sex'),
            'alamatCustomer'=>$this->put('alamatCustomer')
        ];
        if($this->pelanggan->updatePelanggan($data,$id)>0){
            $this->response([
                'status'=>true,
                'pesan'=>'BERHASIL MERUBAH DATA'
            ],REST_Controller::HTTP_ACCEPTED);
        }
        else{
            $this->response([
                'status'=>false,
                'pesan'=>'DATA GAGAL DIUBAH'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
    }
}