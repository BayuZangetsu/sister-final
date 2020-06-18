<?php
use Restserver\Libraries\REST_Controller;

defined('BASEPATH') OR exit('No direct script access allowed');

require APPPATH . 'libraries/REST_Controller.php';

require APPPATH . 'libraries/Format.php';

class tiket extends REST_Controller{
    public function __construct()
    {
        parent::__construct();
        $this->load->model('Model_tiket','tiket');
    }
    public function index_get(){
        $id=$this->get('idTiket');
        $tujuan=$this->get('tujuan');
        if($id===null && $tujuan===null){
            $tiket=$this->tiket->getTiket();
        }
        else if($id!==null && $tujuan===null){
            $tiket=$this->tiket->getTiket($id,$tujuan);
        }
        else if($id===null && $tujuan!==null){
            $tiket=$this->tiket->getTiket($id,$tujuan);
        }
        if($tiket){
            $this->response([
                'status'=>true,
                'data'=>$tiket
            ],REST_Controller::HTTP_OK);
        }
        else
        {
            $this->response([
                'status'=>false,
                'pesan'=>'Data tidak ditemukan :)'
            ],REST_Controller::HTTP_NOT_FOUND);
        }
    }
    public function index_post()
    {
        $data=[
            'tujuan'=>$this->post('tujuan'),
            'harga'=>$this->post('harga')
        ];
        if($this->tiket->createTiket($data)>0){
            $this->response([
                'status'=>true,
                'pesan'=>'TIKET BERHASIL DIBUAT'
            ],REST_Controller::HTTP_CREATED);
        }
        else{
            $this->response([
                'status'=>false,
                'pesan'=>'tiket gagal di input'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
    }
    public function index_put()
    {
        $id=$this->put('idTiket');
        $data=[
            'tujuan'=>$this->put('tujuan'),
            'harga'=>$this->put('harga')
        ];
        if($this->tiket->updateTiket($data,$id)>0){
            $this->response([
                'status'=>true,
                'id'=>$id,
                'pesan'=>'data berhasil diubah!'
            ],REST_Controller::HTTP_ACCEPTED);
        }
        else{
            $this->response([
                'status'=>false,
                'id'=>$id,
                'pesan'=>'data gagal diubah!'
            ],REST_Controller::HTTP_BAD_REQUEST);
            
        }
    }
    public function index_delete()
    {
        $id=$this->delete('idTiket');
        if($id===null){
            $this->response([
                'status'=>false,
                'pesan'=>'MASUKAN ID YANG AKAN DIHAPUS !'
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
        else
        {
            if($this->tiket->deleteTiket($id)>0){
                $this->response([
                    'status'=>true,
                    'id'=>$id,
                    'pesan'=>'id terhapus'
                ],REST_Controller::HTTP_OK);
            }
            else{
                $this->response([
                    'status'=>false,
                    'id'=>$id,
                    'pesan'=>'id tidak ditemukan'
                ],REST_Controller::HTTP_NOT_FOUND);
            }
        }
    }
}