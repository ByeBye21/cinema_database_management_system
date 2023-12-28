using Npgsql;
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
    public partial class update_act : Form
    {
        public update_act()
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
                    cmd.CommandText = "INSERT INTO public.\"Aktör\" (\"Aktör_Ad\") VALUES (@genreName);";
                    cmd.Parameters.AddWithValue("@genreName", Oyuncu_Ad.Text);
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
                    cmd.CommandText = "DELETE FROM public.\"Aktör\" WHERE \"Aktör_ID\" = @genreId;";
                    cmd.Parameters.AddWithValue("@genreId", Convert.ToInt32(Oyuncu_ID.Text));
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
                using (var da = new NpgsqlDataAdapter("SELECT * FROM public.\"Aktör\"", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void update_act_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
