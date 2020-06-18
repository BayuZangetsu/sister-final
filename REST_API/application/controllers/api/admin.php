<?php
use Restserver\Libraries\REST_Controller;
defined('BASEPATH') OR exit('No direct script access allowed');

require APPPATH . 'libraries/REST_Controller.php';

require APPPATH . 'libraries/Format.php';

class admin extends REST_Controller
{
    public function __construct()
    {
        parent::__construct();
        $this->load->model('Model_admin','admin');   
    }
    public function index_get()
    {
        $id=$this->get('userId');
        if($id===null){
            $this->response([
                'status'=>false,
                'pesan'=>"masukan ID !"
            ],REST_Controller::HTTP_BAD_REQUEST);
        }
        else{
            $admin=$this->admin->getAdmin($id);
        }
        if($admin){
            $this->response([
                'status'=>true,
                'data'=>$admin
            ],REST_Controller::HTTP_OK);
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
            'userId'=>$this->post('userId'),
            'password'=>$this->post('password'),
            'nama'=>$this->post('nama')
        ];
        if($this->admin->createAdmin($data)>0){
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
}