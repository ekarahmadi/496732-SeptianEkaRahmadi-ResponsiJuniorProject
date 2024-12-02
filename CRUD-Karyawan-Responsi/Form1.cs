using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Responsi_Junpro2024
{
    public partial class Form1 : Form
    {
        // Koneksi database PostgreSQL
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=responsi";
        private NpgsqlConnection connection; // Objek koneksi ke database
        private DataGridViewRow selectedRow; // Menyimpan baris yang dipilih pada DataGridView

        // Konstruktor Form
        public Form1()
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);

            // Muat data karyawan dan departemen saat form dibuka
            LoadKaryawan();
            LoadDepartemen();
            LoadJabatan();
        }

        // Event Handler untuk tombol Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Query untuk memanggil prosedur tersimpan add_karyawan
                string query = "SELECT add_karyawan(@nama, @id_dep, @id_jabatan)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    // Tambahkan parameter dari input pengguna
                    cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("@id_dep", cbDepartemen.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_jabatan", cbJabatan.SelectedValue);

                    // Eksekusi query
                    connection.Open();
                    int result = (int)cmd.ExecuteScalar(); // Mengembalikan hasil eksekusi prosedur
                    connection.Close();

                    // Tampilkan pesan berdasarkan hasil
                    if (result == 201)
                        MessageBox.Show("Karyawan berhasil ditambahkan.");
                    else
                        MessageBox.Show("Karyawan sudah ada.");
                }

                // Perbarui data karyawan pada DataGridView
                LoadKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Event Handler untuk tombol Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi jika tidak ada baris yang dipilih
                if (selectedRow == null)
                {
                    MessageBox.Show("Pilih data karyawan untuk diperbarui.");
                    return;
                }

                // Ambil data dari baris yang dipilih
                string idKaryawan = selectedRow.Cells["id_karyawan"]?.Value?.ToString();
                if (string.IsNullOrEmpty(idKaryawan)) return;

                // Ambil data baru dari input pengguna
                string namaBaru = tbNama.Text;
                string idDepBaru = cbDepartemen.SelectedValue?.ToString();
                string idJabatanBaru = cbJabatan.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(namaBaru) || string.IsNullOrEmpty(idDepBaru) || string.IsNullOrEmpty(idJabatanBaru))
                {
                    MessageBox.Show("Nama , Departemen, dan Jabatan tidak boleh kosong.");
                    return;
                }

                // Query untuk memperbarui data
                string query = $"UPDATE karyawan SET nama = @nama, id_dep = @id_dep, id_jabatan = @id_jabatan WHERE id_karyawan = '{idKaryawan}'";  // Menambahkan tanda kutip manual
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nama", namaBaru);
                    cmd.Parameters.AddWithValue("@id_dep", idDepBaru);
                    cmd.Parameters.AddWithValue("@id_jabatan", idJabatanBaru);
                    cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);

                    // Eksekusi query
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // Mengembalikan jumlah baris yang diubah
                    connection.Close();

                    // Tampilkan pesan berdasarkan hasil
                    if (rowsAffected > 0)
                    {
                        LoadKaryawan(); // Perbarui tampilan DataGridView
                        MessageBox.Show("Data karyawan berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Data karyawan tidak ditemukan atau tidak ada perubahan.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Event Handler untuk tombol Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi jika tidak ada baris yang dipilih
                if (selectedRow == null)
                {
                    MessageBox.Show("Pilih data karyawan untuk dihapus.");
                    return;
                }

                // Query untuk memanggil prosedur tersimpan delete_karyawan
                string query = "SELECT delete_karyawan(@id_karyawan)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    string idKaryawan = selectedRow.Cells["id_karyawan"].Value.ToString();
                    cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);

                    // Eksekusi query
                    connection.Open();
                    int result = (int)cmd.ExecuteScalar(); // Mengembalikan hasil eksekusi prosedur
                    connection.Close();

                    // Tampilkan pesan berdasarkan hasil
                    if (result == 204)
                        MessageBox.Show("Karyawan berhasil dihapus.");
                    else if (result == 404)
                        MessageBox.Show("Karyawan tidak ditemukan.");
                }

                // Perbarui data karyawan pada DataGridView
                LoadKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Memuat data departemen ke ComboBox
        private void LoadDepartemen()
        {
            try
            {
                string query = "SELECT id_dep, nama_dep FROM departemen";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbDepartemen.DataSource = dataTable;
                    cbDepartemen.DisplayMember = "nama_dep"; // Menampilkan nama departemen
                    cbDepartemen.ValueMember = "id_dep";     // Nilai yang digunakan adalah id departemen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Memuat data jabatan ke ComboBox
        private void LoadJabatan()
        {
            try
            {
                string query = "SELECT id_jabatan, nama_jabatan FROM jabatan";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbJabatan.DataSource = dataTable;
                    cbJabatan.DisplayMember = "nama_jabatan"; // Menampilkan nama departemen
                    cbJabatan.ValueMember = "id_jabatan";     // Nilai yang digunakan adalah id departemen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Memuat data karyawan ke DataGridView
        private void LoadKaryawan()
        {
            try
            {
                string query = "SELECT id_karyawan, nama, id_dep, id_jabatan FROM karyawan";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvKaryawan.DataSource = dataTable;
                    dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event ketika sel DataGridView diklik
        private void dgvKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedRow = dgvKaryawan.Rows[e.RowIndex];

            // Isi TextBox dan ComboBox dengan data dari baris yang dipilih
            tbNama.Text = selectedRow.Cells["nama"]?.Value?.ToString() ?? "";
            cbDepartemen.SelectedValue = selectedRow.Cells["id_dep"]?.Value?.ToString();
            cbJabatan.SelectedValue = selectedRow.Cells["id_jabatan"]?.Value?.ToString();
        }

        // Event untuk tombol Load
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadKaryawan();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
