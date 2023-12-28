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

namespace cinema
{
    public partial class update_sal : Form
    {
        public update_sal()
        {
            InitializeComponent();
        }

        private string _connectionString = "server=localHost; port=5432; Database=cinema; user ID=postgres; password=2220172";
        private void update_sal_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            PopulateFilmsComboBox();
        }

        private void PopulateFilmsComboBox()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT \"Film_ID\", \"Film_Ad\" FROM public.\"Film\"";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        Film.DisplayMember = "Film_Ad";
                        Film.ValueMember = "Film_ID";
                        Film.DataSource = dt;
                    }
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            int kapasite = int.Parse(Kapasite.Text);
            int filmId = int.Parse(Film.SelectedValue.ToString());

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    string salonQuery = "INSERT INTO public.\"Salon\" (\"Film_ID\", \"Sinema_Ad\", \"Kapasite\") " +
                                        "VALUES (@FilmID, @SinemaAd, @Kapasite) RETURNING \"Salon_ID\";";
                    NpgsqlCommand salonCommand = new NpgsqlCommand(salonQuery, connection);
                    salonCommand.Parameters.AddWithValue("@FilmID", filmId);
                    salonCommand.Parameters.AddWithValue("@SinemaAd", Sinema.Text);
                    salonCommand.Parameters.AddWithValue("@Kapasite", kapasite);
                    int salonId = Convert.ToInt32(salonCommand.ExecuteScalar());

                    string koltukQuery = "INSERT INTO public.\"Koltuk\" (\"Salon_ID\") VALUES (@SalonID);";
                    NpgsqlCommand koltukCommand = new NpgsqlCommand(koltukQuery, connection);

                    for (int i = 0; i < kapasite; i++)
                    {
                        koltukCommand.Parameters.Clear(); // Clear previous parameters
                        koltukCommand.Parameters.AddWithValue("@SalonID", salonId);
                        koltukCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var da = new NpgsqlDataAdapter("SELECT * FROM public.\"Salon\"", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int salonId = int.Parse(Salon.Text);

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    string deleteKoltukQuery = "DELETE FROM public.\"Koltuk\" WHERE \"Salon_ID\" = @SalonID;";
                    using (NpgsqlCommand deleteKoltukCmd = new NpgsqlCommand(deleteKoltukQuery, connection))
                    {
                        deleteKoltukCmd.Parameters.AddWithValue("@SalonID", salonId);
                        deleteKoltukCmd.ExecuteNonQuery();
                    }

                    string deleteSalonQuery = "DELETE FROM public.\"Salon\" WHERE \"Salon_ID\" = @SalonID;";
                    using (NpgsqlCommand deleteSalonCmd = new NpgsqlCommand(deleteSalonQuery, connection))
                    {
                        deleteSalonCmd.Parameters.AddWithValue("@SalonID", salonId);
                        var result = deleteSalonCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }

            UpdateDataGridView();
        }
    }
}
