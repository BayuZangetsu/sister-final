<?php
class Model_admin extends CI_Model
{
    public function getAdmin($id)
    {
        return $this->db->get_where('admin',['userId'=>$id])->result_array();
    }
    public function updateAdmin($data,$id)
    {
        $this->db->update('admin',$data,['userId'=>$id]);
        return $this->db->affected_rows();
    }
    public function createAdmin($data)
    {
        $this->db->insert('admin',$data);
        return $this->db->affected_rows();
    }
    public function deleteAdmin($id)
    {
        $this->db->delete('admin',['userId'=>$id]);
        return $this->db->affected_rows();
    }
}