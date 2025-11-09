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

namespace RentalApp
{
    public partial class Barang : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Barang()
        {
            alamat = "server=localhost; database=db_rentalappp; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNBr.Text != "" && txtSewa.Text != "" && txtSt.Text != "")
                {
                    query = "INSERT INTO tbl_barang (nama_barang, harga_sewa, stok) VALUES (@nama_barang, @harga_sewa, @stok)";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNBr.Text);
                    perintah.Parameters.AddWithValue("@harga_sewa", txtSewa.Text);
                    perintah.Parameters.AddWithValue("@stok", txtSt.Text);
                    // adapter tidak diperlukan untuk insert; cukup gunakan perintah.ExecuteNonQuery()
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Sukses ...");
                        Barang_Load_1(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Insert Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Lebih baik tampilkan pesan error yang lebih bersih
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                Barang_Load_1(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            // Kosong, mungkin untuk search lain, tapi tidak diimplementasi
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            // Kosong, mungkin untuk update, tapi sudah ada button3_Click
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Barang_Load_1(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_barang");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Columns[0].Width = 100;
                dataGridView2.Columns[0].HeaderText = "ID Barang";
                dataGridView2.Columns[1].Width = 150;
                dataGridView2.Columns[1].HeaderText = "Nama Barang";
                dataGridView2.Columns[2].Width = 120;
                dataGridView2.Columns[2].HeaderText = "Harga Sewa";
                dataGridView2.Columns[3].Width = 120;
                dataGridView2.Columns[3].HeaderText = "Stok";
                

                txtIDBr.Clear(); 
                txtNBr.Clear();
                txtSewa.Clear();
                txtSt.Clear();
                txtIDBr.Focus();
                btnUP.Enabled = false;
                btnCr.Enabled = false;
                btnSv.Enabled = true;
                btnSh.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }// Kosong, mungkin duplikat dari Barang_Load
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNBr.Text != "" && txtSewa.Text != "" && txtSt.Text != "")
                {

                    query = string.Format("insert into tbl_barang  values ('{0}','{1}','{2}','{3}');", txtIDBr.Text, txtNBr.Text, txtSewa.Text, txtSt.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        Barang_Load_1(null, null);
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

        private void label10_Click(object sender, EventArgs e)
        {
            // Kosong, hapus jika tidak diperlukan
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Kosong, hapus jika tidak diperlukan
        }

        private void textIDB_TextChanged(object sender, EventArgs e)
        {
            // Kosong, hapus jika tidak diperlukan
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNBr.Text != "" && txtSewa.Text != "" && txtSt.Text != "" && txtIDBr.Text != "")
                {
                    query = "UPDATE tbl_barang SET nama_barang = @nama_barang, harga_sewa = @harga_sewa, stok = @stok WHERE id_barang = @id_barang";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNBr.Text);
                    perintah.Parameters.AddWithValue("@harga_sewa", txtSewa.Text);
                    perintah.Parameters.AddWithValue("@stok", txtSt.Text);
                    perintah.Parameters.AddWithValue("@id_barang", txtIDBr.Text);
                    // adapter tidak diperlukan untuk update; cukup gunakan perintah.ExecuteNonQuery()
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Sukses ...");
                        Barang_Load_1(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCr_Click(object sender, EventArgs e)
        {
            try
            {
                Barang_Load_1(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNBr.Text != "")
                {
                    query = "SELECT * FROM tbl_barang WHERE nama_barang = @nama_barang";
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNBr.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    // Hapus perintah.ExecuteNonQuery(); tidak diperlukan sebelum Fill
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtIDBr.Text = kolom["id_barang"].ToString(); // Diperbaiki: id_barang, bukan id_transaksi
                            txtNBr.Text = kolom["nama_barang"].ToString(); // Diperbaiki: nama_barang, bukan nama
                            txtSewa.Text = kolom["harga_sewa"].ToString();
                            txtSt.Text = kolom["stok"].ToString();

                            txtNBr.Enabled = true;
                            dataGridView2.DataSource = ds.Tables[0];
                            btnSv.Enabled = false; // Diperbaiki: konsistensikan nama button
                            btnUP.Enabled = true; // Diperbaiki: konsistensikan nama button
                            btnSh.Enabled = false;
                            btnCr.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        Barang_Load_1(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
