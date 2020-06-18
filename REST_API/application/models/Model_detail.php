<?php
class Model_detail extends CI_Model{
    public function getDetail($id=null)
    {
        if($id===null){
            return $this->db->get('detailtransaksi')->result_array();
        }
        else{
            return $this->db->get_where('detailtransaksi',['idTransaksi'=>$id])->result_array();
        }
    }
    public function createDetail($data)
    {
        $this->db->insert('detailtransaksi',$data);
        return $this->db->affected_rows();
    }
    public function updateDetail($data,$id)
    {
        $this->db->update('detailtransaksi',$data,['idTransaksi'=>$id]);
        return $this->db->affected_rows();
    }
    public function deleteDetail($id)
    {
        $this->db->delete('detailtransaksi',['idTransaksi'=>$id]);
        return $this->db->affected_rows();
    }
}