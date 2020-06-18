<div class="container">      
    <div class="form-group jrk">
        <label for="tujuan">ID Tiket</label>
        <?php
        $jsArray = "var prdName = new Array();\n";  
        echo '<select name="idTiket" class="form-control input-lg" onchange="changeValue(this.value)">';  
        echo '<option>-- Pilih Tujuan --</option>';  
        foreach($tikett as $row) {
            echo '<option name="idTiket" value="' .$row->idTiket. '">' .$row->idTiket. '</option>';  
            $jsArray .= "prdName['" .$row->idTiket. "'] = {tujuan:'" . addslashes($row->tujuan) . "',hargatkt:'".addslashes($row->harga)."'};\n";  
            }  
            echo '</select>';  
            ?> 
            </div>
            <div class="form-group jrk">
                <label for="idTiket">Tujuan</label>
                <input type="text" name="tujuan" id="tujuan" disabled class="form-control input-lg"/>
            </div>
            <div class="form-group jrk">
                <label for="harga">Harga</label>
                <input type="text" name="harga" id="hargatiket" class="form-control input-lg"/>
            </div>
            <script type="text/javascript">
            <?php echo $jsArray; ?>
            function changeValue(id){
                document.getElementById('tujuan').value = prdName[id].tujuan;
                document.getElementById('hargatiket').value = prdName[id].hargatkt;
                };
                </script>
                </div>
                <?php
                foreach($tiket as $row){
                    echo'<option value="'.$row->tujuan.'">'.$row->tujuan.'</option>';
                }?>    
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
            </div> -->
                <div class="form-group jrk invisible">
                    <label for="status">Status</label>
                    <input type="text" class="form-control" id="status" name="status" value="0">
                </div>
                <button type="submit" name="tambah" class="btn btn-primary float-right">Tambah Data</button>
            </form>
        </div>