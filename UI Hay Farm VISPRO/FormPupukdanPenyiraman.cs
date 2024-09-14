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
    public partial class FormPupukdanPenyiraman : Form
    {
        public FormPupukdanPenyiraman()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewInventaris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
