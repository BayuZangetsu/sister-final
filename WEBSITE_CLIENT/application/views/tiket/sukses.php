<div class="container-fluid">
        <?php if($this->session->flashdata('flash')) : ?>
            <div class="row mt-3">
                <div class="col-md-8">
                    <div class="card">
                        <h5 class="card-header hitam">SUKSES</h5>
                        <div class="card-body hitam">
                            <h5 class="card-title"><?= $this->session->flashdata('flash'); ?></h5>
                            <p class="card-text">ID Transaksi anda adalah <b><?php echo $idtrans;?></b>.</p>
                            <a href="<?= base_url(); ?>tiket/" class="btn btn-primary">Kembali</a>
                        </div>
                    </div>
                </div>
            </div>
        <?php endif; ?>
</div>