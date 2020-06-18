using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace TestUiDemo
{
    public partial class UCHome : MetroFramework.Controls.MetroUserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        public void resetText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            FormLogin login = new FormLogin();
            login.Show();
            login.ResetText();
        }

        private void daftar_Click(object sender, EventArgs e)
        {
            if (!FormUtama.Instance.PnlContainer.Controls.ContainsKey("UCRegistrasi"))
            {
                UCRegistrasi ur = new UCRegistrasi();
                ur.Dock = DockStyle.Fill;
                FormUtama.Instance.PnlContainer.Controls.Add(ur);
            }
            FormUtama.Instance.PnlContainer.Controls["UCRegistrasi"].BringToFront();
            FormUtama.Instance.BackButton.Visible = true;
            FormUtama.Instance.labeljudul.Visible = true;
        }

        private void validasi_Click(object sender, EventArgs e)
        {
            if (!FormUtama.Instance.PnlContainer.Controls.ContainsKey("UCValidasi"))
            {
                UCValidasi un = new UCValidasi();
                un.Dock = DockStyle.Fill;
                FormUtama.Instance.PnlContainer.Controls.Add(un);
            }
            FormUtama.Instance.PnlContainer.Controls["UCValidasi"].BringToFront();
            FormUtama.Instance.BackButton.Visible = true;
        }

        private void cari_Click(object sender, EventArgs e)
        {
            if (!FormUtama.Instance.PnlContainer.Controls.ContainsKey("UCCek"))
            {
                UCCek uc = new UCCek();
                uc.Dock = DockStyle.Fill;
                FormUtama.Instance.PnlContainer.Controls.Add(uc);
            }
            FormUtama.Instance.PnlContainer.Controls["UCCek"].BringToFront();
            FormUtama.Instance.BackButton.Visible = true;
        }

        private void kelola_Click(object sender, EventArgs e)
        {
            if (!FormUtama.Instance.PnlContainer.Controls.ContainsKey("UCKelola"))
            {
                UCKelola uc = new UCKelola();
                uc.Dock = DockStyle.Fill;
                FormUtama.Instance.PnlContainer.Controls.Add(uc);
            }
            FormUtama.Instance.PnlContainer.Controls["UCKelola"].BringToFront();
            FormUtama.Instance.BackButton.Visible = true;
        }

        private void daftar_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "\n \n PENDAFTARAN PESANAN\n ";
            textBox2.Text = "Merupakan Form Untuk\n Mendaftarkan Calon Penumpang";
        }

        private void daftar_MouseLeave(object sender, EventArgs e)
        {
            resetText();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {

        }

        private void cari_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "PENCARIAN TRANSAKSI";
            textBox2.Text = "Menu Untuk Mencari Transaksi Yang Sudah Dipesan";
        }

        private void cari_MouseLeave(object sender, EventArgs e)
        {
            resetText();
        }

        private void validasi_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "FORM VALIDASI";
            textBox2.Text = "Menu Untuk Memvalidasi Transaksi Yang Sudah Di buat";
        }

        private void validasi_MouseLeave(object sender, EventArgs e)
        {
            resetText();
        }

        private void kelola_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "PENGELOLAAN TIKET";
            textBox2.Text = "Menu Untuk Membuat, Mengedit dan Menghapus Daftar Tiket";
        }

        private void kelola_MouseLeave(object sender, EventArgs e)
        {
            resetText();
        }

        private void kelolaTransaksi_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "PENGELOLAAN TRANSAKSI";
            textBox2.Text = "Menu Untuk Mengelola History Transaksi Yang Sudah Dipesan";
        }

        private void kelolaTransaksi_Click(object sender, EventArgs e)
        {
            if (!FormUtama.Instance.PnlContainer.Controls.ContainsKey("UCKelolaTransaksi"))
            {
                UCKelolaTransaksi uc = new UCKelolaTransaksi();
                uc.Dock = DockStyle.Fill;
                FormUtama.Instance.PnlContainer.Controls.Add(uc);
            }
            FormUtama.Instance.PnlContainer.Controls["UCKelolaTransaksi"].BringToFront();
            FormUtama.Instance.BackButton.Visible = true;
        }

        private void kelolaTransaksi_MouseLeave(object sender, EventArgs e)
        {
            resetText();
        }
    }
}
