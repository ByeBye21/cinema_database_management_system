using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace cinema
{
    public partial class update_cat : Form
    {
        public update_cat()
        {
            InitializeComponent();
        }

        private string _connectionString = "server=localHost; port=5432; Database=cinema; user ID=postgres; password=2220172";
        private void add_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO public.\"Tür\" (\"Tür_Ad\") VALUES (@genreName);";
                    cmd.Parameters.AddWithValue("@genreName", Tur_Ad.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            UpdateDataGridView();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM public.\"Tür\" WHERE \"Tür_ID\" = @genreId;";
                    cmd.Parameters.AddWithValue("@genreId", Convert.ToInt32(Tur_ID.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var da = new NpgsqlDataAdapter("SELECT * FROM public.\"Tür\"", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void update_cat_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}