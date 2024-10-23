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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void buttonPupukdanPenyiraman_Click(object sender, EventArgs e)
        {
            FormPupukdanPenyiraman formPupukdanPenyiraman = new FormPupukdanPenyiraman();
            formPupukdanPenyiraman.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormJadwalpanen formJadwalpanen = new FormJadwalpanen();
            formJadwalpanen.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Formlogin formlogin = new Formlogin();
            formlogin.Show();
            this.Hide();
        }

        private void buttonInventaris_Click(object sender, EventArgs e)
        {
            FormInventaris formInventaris = new FormInventaris();
            formInventaris.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPengaturan frmPengaturan = new FrmPengaturan();
            frmPengaturan.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormInventaris formInventaris = new FormInventaris();
            formInventaris.Show();
            this.Hide();
        }
    }
}
