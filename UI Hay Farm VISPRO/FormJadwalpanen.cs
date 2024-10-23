using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Hay_Farm_VISPRO
{
    public partial class FormJadwalpanen : Form
    {
        public FormJadwalpanen()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // Cek setiap 1 detik (1000 ms)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Dapatkan waktu sekarang
            DateTime waktuSekarang = DateTime.Now;

            // Jika waktu sekarang sama atau lebih besar dari waktu panen
            if (waktuSekarang >= waktuPanen)
            {
                // Tampilkan notifikasi ke user
                MessageBox.Show("Sudah waktunya panen untuk " + txtNamatanaman.Text + "!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Stop timer agar notifikasi tidak berulang-ulang
                (sender as Timer).Stop();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmMain formMain = new FrmMain();
            formMain.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void FormJadwalpanen_Load(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void txtNamatanaman_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTanggalPanen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Ambil waktu panen dari DateTimePicker
            waktuPanen = dtpTanggalPanen.Value;

            // Beri tahu user bahwa pengingat panen telah diatur
            MessageBox.Show("Pengingat panen telah diatur untuk " + txtNamatanaman.Text + " pada " + waktuPanen.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
