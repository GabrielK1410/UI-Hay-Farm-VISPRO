using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UI_Hay_Farm_VISPRO
{
    public partial class FrmPengaturan : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmPengaturan()
        {
            alamat = "server=localhost; database=db_hayfarm; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void buttonInventaris_Click(object sender, EventArgs e)
        {
            FormInventaris formInventaris = new FormInventaris();
            formInventaris.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPengaturan_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_loginform");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Pengguna";
                dataGridView1.Columns[1].Width = 400;
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].Width = 500;
                dataGridView1.Columns[2].HeaderText = "Password";
             

                txtID.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
                txtID.Focus();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSearch.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtUsername.Text != "")
                {
                    query = string.Format("UPDATE tbl_loginform SET password = '{0}', username = '{1}' WHERE id = '{2}'", txtPassword.Text, txtUsername.Text, txtID.Text);

                    using (MySqlCommand perintah = new MySqlCommand(query, koneksi))
                    {
                        if (koneksi.State == ConnectionState.Closed)
                        {
                            koneksi.Open();  // Open the connection only if it's closed
                        }

                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();  // Close the connection immediately after executing the query

                        if (res == 1)
                        {
                            MessageBox.Show("Edit Data Sukses ...");
                            FrmPengaturan_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Gagal Edit Data ...");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "")
                {
                    query = string.Format("select * from tbl_loginform where username = '{0}'", txtUsername.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtID.Text = kolom["id"].ToString();
                            txtPassword.Text = kolom["password"].ToString();
                            txtUsername.Text = kolom["username"].ToString();

                        }
                        txtUsername.Enabled = true;
                        dataGridView1.DataSource = ds.Tables[0];
                        btnEdit.Enabled = true;
                        btnEdit.Enabled = true;
                        btnSearch.Enabled = false;
                        btnClear.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        FrmPengaturan_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
                {

                    query = string.Format("insert into tbl_loginform  values ('{0}','{1}','{2}');", txtUsername.Text, txtPassword.Text, txtID.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        FrmPengaturan_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "") // Pastikan ada ID yang akan dihapus
                {
                    // Konfirmasi sebelum menghapus data
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("DELETE FROM tbl_loginform WHERE id = '{0}'", txtID.Text);

                        if (koneksi.State == ConnectionState.Closed)
                        {
                            koneksi.Open(); // Buka koneksi sebelum menjalankan query
                        }

                        MySqlCommand perintah = new MySqlCommand(query, koneksi);
                        int res = perintah.ExecuteNonQuery(); // Jalankan perintah delete
                        koneksi.Close(); // Tutup koneksi setelah operasi

                        if (res == 1) // Cek jika penghapusan berhasil
                        {
                            MessageBox.Show("Delete Data Sukses ...");
                            FrmPengaturan_Load(null, null); // Reload form dan data
                            btnDelete.Enabled = false; // Nonaktifkan tombol Delete setelah delete
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete Data");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtID.Clear();
                txtPassword.Clear();
                txtUsername.Clear();

                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSearch.Enabled = true;

                // Reload data after clearing
                FrmPengaturan_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmMain formMain = new FrmMain();
            formMain.Show();
            this.Hide();
        }
    }
}
