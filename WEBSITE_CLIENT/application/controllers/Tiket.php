<?php

class Tiket extends CI_Controller{
    public function __construct()
    {
        parent::__construct();
        $this->load->model('Tiket_model');
        $this->load->library('form_validation');
    }

    public function index()
    {
        $data['title'] ='Selamat Datang';

        $this->load->view('templates/header',$data);
        $this->load->view('tiket/index', $data);
        $this->load->view('templates/footer');
    }

    public function booking()
    {
        $data['title'] ='Booking Tiket';
        $data['tikett'] = $this->Tiket_model->tikettujuharga();
        $data['tiket'] = $this->Tiket_model->tiket_fetch();
        $data['idcus'] = $this->Tiket_model->dapatCus();

        $this->form_validation->set_rules('nik', 'NIK', 'required|numeric');
        $this->form_validation->set_rules('namaCustomer', 'Nama', 'required');
        $this->form_validation->set_rules('alamatCustomer', 'Alamat', 'required');

        if($this->form_validation->run() == FALSE){
            $this->load->view('templates/header', $data);
            $this->load->view('tiket/booking', $data);
            $this->load->view('templates/footer');
        } else{
            $this->Tiket_model->tambahData();
            $this->session->set_flashdata('flash', 'Data berhasil Ditambahkan');
            redirect('tiket/sukses');
        }

    }

    public function cektiket()
    {
        $data['title'] = 'Cek Tiket';
        $data['cek'] = $this->Tiket_model->dapatID();
        if($this->input->post('keyword')){
            $data['cek'] = $this->Tiket_model->cariID();
        }

        $this->load->view('templates/header',$data);
        $this->load->view('tiket/cektiket', $data);
        $this->load->view('templates/footer');
    }


    public function info($id)
    {
        $data['title'] = 'Informasi Tiket';
        $data['cek'] = $this->Tiket_model->infoID($id);

        $this->load->view('templates/header',$data);
        $this->load->view('tiket/informasi', $data);
        $this->load->view('templates/footer');
    }

    public function sukses()
    {
        $data['title'] = 'Berhasil';
        $data['idtrans'] = $this->Tiket_model->idtrans();

        $this->load->view('templates/header',$data);
        $this->load->view('tiket/sukses', $data);
        $this->load->view('templates/footer');
    }
    public function Booktransaksi($id){
        $data['idCustomer']=$this->tiket_model->dapatcus2($id);
        $this->load->view('templates/header');
        $this->load->view('tiket/bookingTR',$data);
        $this->load->view('templates/footer');
    }
}