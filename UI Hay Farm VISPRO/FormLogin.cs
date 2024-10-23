using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UI_Hay_Farm_VISPRO
{
    public partial class Formlogin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Formlogin()
        {
            alamat = "server=localhost; database=db_hayfarm; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                        string sandi;
                        sandi = kolom["password"].ToString();
                        if (sandi == txtPassword.Text)
                        {
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all necessary fields are filled
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    // Step 1: Check if the username already exists
                    string checkQuery = string.Format("SELECT * FROM tbl_loginform WHERE username = '{0}'", txtUsername.Text);
                    DataSet dsCheck = new DataSet();
                    koneksi.Open();
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, koneksi);
                    MySqlDataAdapter checkAdapter = new MySqlDataAdapter(checkCmd);
                    checkAdapter.Fill(dsCheck);
                    koneksi.Close();

                    if (dsCheck.Tables[0].Rows.Count > 0)
                    {
                        // If the username already exists, show a message
                        MessageBox.Show("Username sudah terdaftar. Silakan gunakan username lain.");
                    }
                    else
                    {
                        // Step 2: Insert the new account into the database
                        string insertQuery = string.Format("INSERT INTO tbl_loginform (username, password) VALUES ('{0}', '{1}')", txtUsername.Text, txtPassword.Text);

                        koneksi.Open();
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, koneksi);
                        int result = insertCmd.ExecuteNonQuery(); // Execute the insert query
                        koneksi.Close();

                        if (result == 1) // If insert was successful
                        {
                            MessageBox.Show("Akun berhasil ditambahkan!");
                            // Clear the text fields after successful insertion
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan akun.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak lengkap. Mohon lengkapi semua field.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void ClearFormFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            // Clear other fields if necessary
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
