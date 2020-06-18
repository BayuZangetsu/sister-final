<div class="container-fluid">
        <div class="alert alert-primary m-5 text-center kotak apa" role="alert">
            <h1>Projek Sistem Terdistribusi</h1>
            <p> Projek sistem terdistribusi untuk penilaian tugas akhir </p>
            <p><b>KELOMPOK BOCAH GABUT</b></p>
        </div>
        <?php if($this->session->flashdata('flash')) : ?>
            <div class="row mt-3">
                <div class="col-md-6">
                    <div class="alert alert-success alert-dismissible fade show" role="alert">
                        <strong>Berhasil!</strong> <?= $this->session->flashdata('flash'); ?>.
                        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                </div>
            </div>
        <?php endif; ?>
    </div>