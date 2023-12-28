using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cinema
{
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }

        private string _connectionString = "server=localHost; port=5432; Database=cinema; user ID=postgres; password=2220172";
        private void buy_Load(object sender, EventArgs e)
        {
            PopulateSalonsComboBox();
            UpdateDataGridView();
        }

        private void PopulateSalonsComboBox()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT \"Salon_ID\", \"Film_ID\" FROM public.\"Salon\"";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        Salon.DisplayMember = "Salon_ID";
                        Salon.ValueMember = "Film_ID";
                        Salon.DataSource = dt;
                    }
                }
            }
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            string customerName = Ad.Text;
            int filmId = (int)Salon.SelectedValue;
            int defaultKoltukId = 1;

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();


                // Insert customer and get ID
                string insertCustomerSql = "INSERT INTO public.\"Müşteri\" (\"Müşteri_Ad\") VALUES (@CustomerName) RETURNING \"Müşteri_ID\";";
                var cmd = new NpgsqlCommand(insertCustomerSql, conn);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                int customerId = (int)cmd.ExecuteScalar();

                // Insert ticket with a default Koltuk ID
                string insertTicketSql = "INSERT INTO public.\"Bilet\" (\"Film_ID\", \"Müşteri_ID\", \"Koltuk_ID\") VALUES (@FilmId, @CustomerId, @KoltukId);";
                var ticketCmd = new NpgsqlCommand(insertTicketSql, conn);
                ticketCmd.Parameters.AddWithValue("@FilmId", filmId);
                ticketCmd.Parameters.AddWithValue("@CustomerId", customerId);
                ticketCmd.Parameters.AddWithValue("@KoltukId", defaultKoltukId); // insert the default Koltuk ID
                ticketCmd.ExecuteNonQuery();
            }

            UpdateDataGridView();
        }


        private void UpdateDataGridView()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var da = new NpgsqlDataAdapter("SELECT * FROM public.\"TicketDetails\"", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
