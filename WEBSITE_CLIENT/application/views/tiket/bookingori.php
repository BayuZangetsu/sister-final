<div class="container-fluid">
    <div class="row mt-4">
        <div class="col-md-12 col-sm-12 col-xs-12">
            <form action="" method="post">
                <h1 class="text-center">Booking Tiket</h1>

                <div class="form-group jrk invisible">
                    <label for="idCustomer">ID Customer</label>
                    <input type="text" class="form-control" value="<?php echo $idcus;?>" id="idCustomer" name="idCustomer">
                </div>

                <div class="form-group jrk">
                    <label for="nik">NIK</label>
                    <input type="text" class="form-control" id="nik" name="nik">
                    <small class="form-text text-danger"><?= form_error('nik'); ?></small>
                </div>

                <div class="form-group jrk">
                    <label for="namaCustomer">Nama</label>
                    <input type="text" class="form-control" id="namaCustomer" name="namaCustomer">
                    <small class="form-text text-danger"><?= form_error('namaCustomer'); ?></small>
                </div>
                        
                <div class="form-group jrk">
                    <label for="sex">Jenis Kelamin</label>
                    <select class="form-control" id="sex" name="sex">
                        <option> </option>
                        <option value="Laki-laki">Laki-laki</option>
                        <option value="Perempuan">Perempuan</option>
                    </select>
                </div>
                        
                <div class="form-group jrk">
                    <label for="alamatCustomer">Alamat</label>
                    <textarea class="form-control" id="alamatCustomer" rows="5" name="alamatCustomer"></textarea>
                    <small class="form-text text-danger"><?= form_error('alamatCustomer'); ?></small>
                </div>

                <div class="form-group jrk">
                    <label for="idTiket">ID Tiket</label>
                    <input type="text" class="form-control" value="<?php echo $idtkt;?>" id="idTiket" name="idTiket">
                </div>

                <div class="form-group jrk">
                    <label for="tujuan">Tujuan</label>
                    <select name="tujuan" id="tujuan" class="form-control input-lg">
                        <option value="">Pilih Tujuan</option>
                        <?php
                            foreach($tiket as $row){
                                echo'<option value="'.$row->tujuan.'">'.$row->tujuan.'</option>';
                            }
                        ?>
                    </select>
                </div>

                <div class="form-group jrk">
                    <label for="harga">Harga</label>
                    <select name="harga" id="harga" class="form-control input-lg">
                        <option value="">Harga Tiket</option>
                        <?php
                            foreach($tiket as $row){
                                echo'<option value="'.$row->harga.'">'.$row->harga.'</option>';
                            }
                        ?>
                    </select>
                </div>

                <div class="form-group jrk invisible">
                    <label for="status">Status</label>
                    <input type="text" class="form-control" id="status" name="status" value="0">
                </div>
                
                <button type="submit" name="tambah" class="btn btn-primary float-right">Tambah Data</button>
            </form>
        </div>
    
    </div>
</div>