<?php
class Model_tiket extends CI_Model{
    public function getTiket($id=null,$tujuan=null){
        if($id===null && $tujuan === null){
            return $this->db->get('tiket')->result_array();
        }
        else if($id !== null && $tujuan === null){
            return $this->db->get_where('tiket',['idTiket'=>$id])->result_array();
        }
        else if($id===null && $tujuan !== null){
          //  return $this->db->get('customer')->result_array();
            return $this->db->get_where('tiket',['tujuan'=>$tujuan])->result_array();
        }
    }
    public function createTiket($data)
    {
        $this->db->insert('tiket',$data);
        return $this->db->affected_rows();
    }
    public function updateTiket($data,$id)
    {
       $this->db->update('tiket',$data,['idTiket'=>$id]);
       return $this->db->affected_rows();
    }
    public function deleteTiket($id)
    {
        $this->db->delete('tiket',['idTiket'=>$id]);
        return $this->db->affected_rows();
    }
}