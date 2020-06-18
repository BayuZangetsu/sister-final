<div class="container-fluid">
    <div class="row mt-3">
        <div class="col-md-12">
            <div class="pos">
            <form action="" method="post">
            <h1>Cek Tiket</h1>
        </div>
        <div class="input-group mt-3">
            <input type="text" class="form-control" placeholder="Masukkan ID Transaksi anda" name="keyword">
            <div class="input-group-append">
                <button class="btn btn-outline-primary ml-3" type="submit">Cari</button>
            </div>
        </div>
            <div class="row mt-3 hitam">
            <div class="col-lg-2"></div>
            <div class="col-lg-8 hitam">
                <?php if(empty($cek)):?>
                <div class="alert alert-danger" role="alert">ID Transaksi tidak ditemukan</div>
                <?php endif;?>
                <ul class="list-group">
                    <?php foreach ($cek as $row) : ?>
                    <li class="list-group-item">
                        <?= $row['idTransaksi']; ?> &nbsp; &nbsp; &nbsp;<?= $row['tglTransaksi']; ?> &nbsp;
                        &nbsp; &nbsp;<?= $row['idCustomer']; ?> &nbsp; &nbsp; &nbsp;<?= $row['idTiket']; ?>&nbsp; &nbsp; &nbsp;<?= $row['status']; ?>
                            <a href="<?= base_url(); ?>tiket/info/<?= $row['idTransaksi']?>" class="btn btn-primary btn-sm float-right">Info</a>
                        </li>
                        <?php endforeach;?>
                    </ul>

                <!-- <ul>
                    <?php foreach ($cek as $row) : ?>
                        <li><?= $row['idTransaksi']; ?></li>
                        <li><?= $row['tglTransaksi']; ?></li>
                        <li><?= $row['idCustomer']; ?></li>
                        <li><?= $row['idTiket']; ?></li>
                        <li><?= $row['status']; ?>
                        <a href="<?= base_url(); ?>tiket/info/<?= $row['idTransaksi']?>" class="btn btn-primary btn-sm float-right">Info</a>
                    </li>
                    <?php endforeach;?>
                    </ul> -->
                </div>
                <div class="col-lg-2"></div>
            </div>
            </form>
        </div>
    <!-- </div> -->
</div>