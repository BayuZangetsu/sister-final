<?php
class Model_transaksi extends CI_Model{
    public function getTransaksi($id=null,$cust=null)
    {
        if($id===null&&$cust===null){
            return $this->db->get('transaksi')->result_array();
        }
        else if($id!==null&&$cust===null){
            return $this->db->get_where('transaksi',['idTransaksi'=>$id])->result_array();
        }
        else if($id===null&&$cust!==null){
            return $this->db->get_where('transaksi',['idCustomer'=>$cust])->result_array();
        }
    }
    public function createTransaksi($data)
    {
        $this->db->insert('transaksi',$data);
        return $this->db->affected_rows();
    }
    public function updateTransaksi($data,$id)
    {
        $this->db->update('transaksi',$data,['idTransaksi'=>$id]);
        return $this->db->affected_rows();
    }
    public function deleteTransaksi($id)
    {
        $this->db->delete('transaksi',['idTransaksi'=>$id]);
        return $this->db->affected_rows();
    }
}