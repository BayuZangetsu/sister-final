<?php
use Restserver\Libraries\REST_Controller;

defined('BASEPATH') OR exit('No direct script access allowed');

require APPPATH . 'libraries/REST_Controller.php';

require APPPATH . 'libraries/Format.php';
class transaksi extends REST_Controller{
    public function __construct()
    {
        parent::__construct();
        $this->load->model('Model_transaksi','transaksi');
    }
    public function index_get()
    {
        $id=$this->get('idTransaksi');
        $cust=$this->get('idCustomer');
        if($id===null&&$cust===null){
            $transaksi=$this->transaksi->getTransaksi();
        }
        else if($id!==null&&$cust===null){
            $transaksi=$this->transaksi->getTransaksi($id,$cust);
        }
        else if($id===null&&$cust!==null){
            $transaksi=$this->transaksi->getTransaksi($id,$cust);
        }
        if($transaksi){
            $this->response([
                'status'=>true,
                'data'=>$transaksi
            ],REST_Controller::HTTP_OK);
        }
        else{
            $this->response([
                'status'=>false,
                'data'=>'data tidak ditemukan'
            ],REST_Controller::HTTP_OK);    
        }
    }
    public function index_put()
    {
        $id=$this->put('idTransaksi');
        $data=[
            'idCustomer'=>$this->put('idCustomer'),
            'idTiket'=>$this->put('idTiket'),
            'status'=>$this->put('status')
        ];
        if($id===null){
            $this->response([
                'status'=>false,
                'pesan'=>'harap input id'
            ],REST_Controller::HTTP_FORBIDDEN);
        }
        if($this->transaksi->updateTransaksi($data,$id)>0){
            $this->response([
                'status'=>true,
                'id'=>$id,
                'pesan'=>'Data berhasil di Update'
            ],REST_Controller::HTTP_CREATED);
        }
        else{
            $this->response([
                'status'=>false,
                'id'=>$id,
                'pesan'=>'Data gagal ter update'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
    }
    public function index_post()
    {
        $data=[
            'idCustomer'=>$this->post('idCustomer'),
            'idTiket'=>$this->post('idTiket'),
            'status'=>$this->post('status')
        ];
        if($this->transaksi->createTransaksi($data)>0){
            $this->response([
                'status'=>true,
                'id'=>$data,
                'pesan'=>'Data berhasil di input'
            ],REST_Controller::HTTP_CREATED);
        }
        else{
            $this->response([
                'status'=>false,
                'pesan'=>'Data gagal terinput'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
    }
    public function index_delete()
    {
        $id=$this->delete('idTransaksi');
        if($id===null){
            $this->response([
                'status'=>false,
                'pesan'=>'harap masukan id terlebih dahulu'
            ],REST_Controller::HTTP_FORBIDDEN);
        }
        else{
            if($this->transaksi->deleteTransaksi($id)>0){
                $this->response([
                    'status'=>true,
                    'id'=>$id,
                    'pesan'=>'Data berhasil di hapus'
                ],REST_Controller::HTTP_OK);
            }
            else{
                $this->response([
                    'status'=>false,
                    'id'=>$id,
                    'pesan'=>'Data gagal di hapus'
                ],REST_Controller::HTTP_BAD_REQUEST);
            }
        }
    }
}