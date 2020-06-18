<?php
use Restserver\Libraries\REST_Controller;

defined('BASEPATH') OR exit('No direct script access allowed');

require APPPATH . 'libraries/REST_Controller.php';

require APPPATH . 'libraries/Format.php';

class detail extends REST_Controller{
    public function __construct()
    {
        parent::__construct();
        $this->load->model('Model_detail','detail');   
    }
    public function index_get()
    {
        $id=$this->get('idTransaksi');
        if($id===null){
            $detail=$this->detail->getDetail();
        }
        else{
            $detail=$this->detail->getDetail($id);
        }
        if($detail){
            $this->response([
                'status'=>true,
                'data'=>$detail
            ],REST_Controller::HTTP_OK);
        }
        else{
            $this->response([
                'status'=>false,
                'pesan'=>'ID TRANSAKSI TIDAK DITEMUKAN'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
    }
    public function index_post()
    {
      $data=[
          'idTransaksi'=>$this->post('idTransaksi'),
          'idTiket'=>$this->post('idTiket')
      ];
      if($this->detail->createDetail($data)>0){
          $this->response([
              'status'=>true,
              'pesan'=>'DATA BERHASIL DI INPUT'
          ],REST_Controller::HTTP_CREATED);
      }
      else{
          $this->response([
              'status'=>false,
              'pesan'=>'DATA GAGAL DI INPUT'
          ],REST_Controller::HTTP_BAD_REQUEST);
      }
    }
    public function index_put()
    {
      $id=$this->put('idTransaksi');
      $data=[
          'idTiket'=>$this->put('idTiket')
      ];
      if($id===null){
        $this->response([
            'status'=>false,
            'pesan'=>'HARAP MASUKAN ID YANG AKAN DIUBAH'
        ],REST_Controller::HTTP_FORBIDDEN);
      }
      else{
        if($this->detail->updateDetail($data,$id)>0){
            $this->response([
                'status'=>true,
                'pesan'=>'DATA BERHASIL DI UPDATE'
            ],REST_Controller::HTTP_CREATED);
          }
          else{
            $this->response([
                'status'=>false,
                'pesan'=>'DATA GAGAL DI UPDATE'
            ],REST_Controller::HTTP_BAD_REQUEST);
          }
      }
    }
    public function index_delete()
    {
      $id=$this->delete('idTransaksi');
      if($id===null){
        $this->response([
            'status'=>false,
            'pesan'=>'HARAP MASUKAN ID YANG AKAN DIHAPUS'
        ],REST_Controller::HTTP_FORBIDDEN);
      }
      if($this->detail->deleteDetail($id)>0){
        $this->response([
            'status'=>true,
            'pesan'=>'DATA BERHASIL DI HAPUS'
        ],REST_Controller::HTTP_OK);
      }
      else{
        $this->response([
            'status'=>false,
            'pesan'=>'DATA GAGAL DI HAPUS'
        ],REST_Controller::HTTP_BAD_REQUEST);
      }
    }
}