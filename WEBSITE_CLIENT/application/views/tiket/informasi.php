<div class="container-fluid">
    <div class="row mt-3">
        <div class="col-md-8">
            <div class="card">
                <div class="card-header hitam">
                INFORMASI TIKET
                </div>
                <div class="card-body hitam">
                    <h1 class="card-title hitam"><?= $cek['idTransaksi']; ?></h1>
                    <p class="card-text hitam"><?= $cek['tglTransaksi']; ?></p>
                    <p class="card-text hitam">ID Customer : <b><?= $cek['idCustomer']; ?></b></p>
                    <p class="card-text hitam">ID Tiket : <b><?= $cek['idTiket']; ?></b></p>
                    <?php if($cek['status']==0){
                        $statusnya="BELUM DIVALIDASI";
                    }
                    else {
                        $statusnya="SUDAH DIVALIDASI";
                    }?>
                    <p class="card-text hitam">Status : <b><?= $statusnya; ?></b></p>
                    
                    <a href="<?= base_url(); ?>tiket/cektiket/" class="btn btn-primary">Kembali</a>
                </div>
            </div>
        </div>
    </div>
</div>