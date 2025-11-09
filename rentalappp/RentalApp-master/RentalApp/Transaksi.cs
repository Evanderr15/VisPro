using System;
using System.Collections;
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
    public partial class Transaksi : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Transaksi()
        {
            alamat = "server=localhost; database=db_rentalappp; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBBar.Text != "" && txtNama.Text != "" && txtAlamat.Text != "" && txtTelepon.Text != "" && txtJaminan.Text != "" && dtpM.Text != "" && dtpK.Text != "" && CBStatus.Text != "" && txtTotal.Text != "")
                {
                    // Cari id_barang berdasarkan nama_barang yang dipilih
                    string idBarang = GetIdBarangByNama(CBBar.Text);
                    if (string.IsNullOrEmpty(idBarang))
                    {
                        MessageBox.Show("Nama barang tidak ditemukan!");
                        return;
                    }

                    query = "INSERT INTO tbl_transaksi (id_barang, nama, alamat, telepon, jaminan, TanggalMulai, TanggalKembali, Status, totalBiaya) VALUES (@id_barang, @nama, @alamat, @telepon, @jaminan, @TanggalMulai, @TanggalKembali, @Status, @totalBiaya)";
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@id_barang", idBarang);
                    perintah.Parameters.AddWithValue("@nama", txtNama.Text);
                    perintah.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    perintah.Parameters.AddWithValue("@telepon", txtTelepon.Text);
                    perintah.Parameters.AddWithValue("@jaminan", txtJaminan.Text);
                    perintah.Parameters.AddWithValue("@TanggalMulai", dtpM.Value);
                    perintah.Parameters.AddWithValue("@TanggalKembali", dtpK.Value);
                    perintah.Parameters.AddWithValue("@Status", CBStatus.Text);
                    perintah.Parameters.AddWithValue("@totalBiaya", txtTotal.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Sukses ...");
                        Transaksi_Load(null, null);
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "" && txtAlamat.Text != "" && txtTelepon.Text != "" && txtJaminan.Text != "" && dtpM.Text != "" && dtpK.Text != "" && CBStatus.Text != "" && txtTotal.Text != "")
                {
                    // Cari id_barang berdasarkan nama_barang yang dipilih
                    string idBarang = GetIdBarangByNama(CBBar.Text);
                    if (string.IsNullOrEmpty(idBarang))
                    {
                        MessageBox.Show("Nama barang tidak ditemukan!");
                        return;
                    }

                    query = "UPDATE tbl_transaksi SET id_barang = @id_barang, nama = @nama, alamat = @alamat, telepon = @telepon, jaminan = @jaminan, TanggalMulai = @TanggalMulai, TanggalKembali = @TanggalKembali, Status = @Status, totalBiaya = @totalBiaya WHERE id_transaksi = @id_transaksi";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@id_barang", idBarang);
                    perintah.Parameters.AddWithValue("@nama", txtNama.Text);
                    perintah.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    perintah.Parameters.AddWithValue("@telepon", txtTelepon.Text);
                    perintah.Parameters.AddWithValue("@jaminan", txtJaminan.Text);
                    perintah.Parameters.AddWithValue("@TanggalMulai", dtpM.Value);
                    perintah.Parameters.AddWithValue("@TanggalKembali", dtpK.Value);
                    perintah.Parameters.AddWithValue("@Status", CBStatus.Text);
                    perintah.Parameters.AddWithValue("@totalBiaya", txtTotal.Text);
                    perintah.Parameters.AddWithValue("@id_transaksi", txtIDT.Text);

                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Sukses ...");
                        Transaksi_Load(null, null);
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCL_Click(object sender, EventArgs e)
        {
            try
            {
                Transaksi_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "")
                {
                    query = "SELECT * FROM tbl_transaksi WHERE nama = @nama";
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama", txtNama.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtIDT.Text = kolom["id_transaksi"].ToString();
                            txtNama.Text = kolom["nama"].ToString();
                            txtAlamat.Text = kolom["alamat"].ToString();
                            txtTelepon.Text = kolom["telepon"].ToString();
                            txtJaminan.Text = kolom["jaminan"].ToString();
                            CBBar.Text = GetNamaBarangById(kolom["id_barang"].ToString());
                            dtpM.Value = DateTime.Parse(kolom["TanggalMulai"].ToString());
                            dtpK.Value = DateTime.Parse(kolom["TanggalKembali"].ToString());
                            CBStatus.Text = kolom["Status"].ToString();
                            txtTotal.Text = kolom["totalBiaya"].ToString();
                        }
                        txtNama.Enabled = true;
                        dataGridView1.DataSource = ds.Tables[0];
                        btnSimpan.Enabled = true;
                        btnUP.Enabled = true;
                        btnSc.Enabled = false;
                        btnCL.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        Transaksi_Load(null, null);
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

        private void btnBb_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            try
            {
                // Isi CBBar dengan nama_barang dari tbl_barang
                koneksi.Open();
                query = "SELECT nama_barang FROM tbl_barang";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                DataSet dsBarang = new DataSet();
                adapter.Fill(dsBarang);
                koneksi.Close();

                CBBar.Items.Clear();
                foreach (DataRow row in dsBarang.Tables[0].Rows)
                {
                    CBBar.Items.Add(row["nama_barang"].ToString());
                }

                
                

                // Load data transaksi ke DataGridView
                koneksi.Open();
                query = "SELECT * FROM tbl_transaksi";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];

                // Atur HeaderText dan Width untuk DataGridView
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Transaksi";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "ID Barang";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Nama";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Alamat";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Telepon";
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[5].HeaderText = "Jaminan";
                dataGridView1.Columns[6].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Tanggal Mulai";
                dataGridView1.Columns[7].Width = 120;
                dataGridView1.Columns[7].HeaderText = "Tanggal Kembali";
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[8].HeaderText = "Status";
                dataGridView1.Columns[9].Width = 120;
                dataGridView1.Columns[9].HeaderText = "Biaya Total";

                // Clear semua field
                txtIDT.Clear();
                txtNama.Clear();
                txtAlamat.Clear();
                txtTelepon.Clear();
                txtJaminan.Clear();
                txtTotal.Clear();
                CBBar.Text = "";
                CBStatus.Text = "";
                

                txtIDT.Focus();
                btnUP.Enabled = false;
                btnCL.Enabled = false;
                btnSimpan.Enabled = true;
                btnSc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Helper method: Cari id_barang berdasarkan nama_barang
        private string GetIdBarangByNama(string nama_barang)
        {
            try
            {
                koneksi.Open();
                query = "SELECT id_barang FROM tbl_barang WHERE nama_barang = @nama_barang";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@nama_barang", nama_barang);
                object result = perintah.ExecuteScalar();
                koneksi.Close();
                return result?.ToString();
            }
            catch
            {
                koneksi.Close();
                return null;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBBar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            barang.Show();
            this.Hide();
        }

        // Helper method: Cari nama_barang berdasarkan id_barang (untuk display saat search)
        private string GetNamaBarangById(string idBarang)
        {
            try
            {
                koneksi.Open();
                query = "SELECT nama_barang FROM tbl_barang WHERE id_barang = @id_barang";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@id_barang", idBarang);
                object result = perintah.ExecuteScalar();
                koneksi.Close();
                return result?.ToString();
            }
            catch
            {
                koneksi.Close();
                return null;
            }
        }
    }
}
