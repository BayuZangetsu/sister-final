<?php
class Model_pelanggan extends CI_Model{
    public function getPelanggan($id=null,$nik=null){
        if($id===null && $nik === null){
            return $this->db->get('customer')->result_array();
        }
        else if($id !== null && $nik === null){
            return $this->db->get_where('customer',['idCustomer'=>$id])->result_array();
        }
        else if($id===null && $nik !== null){
          //  return $this->db->get('customer')->result_array();
            return $this->db->get_where('customer',['nik'=>$nik])->result_array();
        }
        //else{
        //}
    }
    public function deletePelanggan($id)
    {
        $this->db->delete('customer',['idCustomer'=>$id]);
        return $this->db->affected_rows();
    }
    public function createPelanggan($data)
    {
        $this->db->insert('customer',$data);
        return $this->db->affected_rows();
    }
    public function updatePelanggan($data,$id)
    {
        $this->db->update('customer',$data,['idCustomer'=>$id]);
        return $this->db->affected_rows();
    }
}