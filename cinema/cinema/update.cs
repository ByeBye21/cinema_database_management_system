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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private string _connectionString = "server=localHost; port=5432; Database=cinema; user ID=postgres; password=2220172";
        private void update_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            PopulateDirectorsComboBox();
            PopulateActorsCheckedListBox();
            PopulateGenresCheckedListBox();
        }

        private void PopulateDirectorsComboBox()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT \"Yönetmen_ID\", \"Yönetmen_Ad\" FROM public.\"Yönetmen\"";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        Yonetmen.DisplayMember = "Yönetmen_Ad";
                        Yonetmen.ValueMember = "Yönetmen_ID";
                        Yonetmen.DataSource = dt;
                    }
                }
            }
        }

        private void PopulateActorsCheckedListBox()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT \"Aktör_ID\", \"Aktör_Ad\" FROM public.\"Aktör\"";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        Oyuncular.DataSource = dt;
                        Oyuncular.DisplayMember = "Aktör_Ad";
                        Oyuncular.ValueMember = "Aktör_ID";
                    }
                }
            }
        }

        private void PopulateGenresCheckedListBox()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT \"Tür_ID\", \"Tür_Ad\" FROM public.\"Tür\"";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        Tur.DataSource = dt;
                        Tur.DisplayMember = "Tür_Ad";
                        Tur.ValueMember = "Tür_ID";
                    }
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                int FilmID;

                using (var transaction = conn.BeginTransaction())
                {
                    string insertFilmSql = "INSERT INTO public.\"Film\" (\"Film_Ad\", \"Degerlendirme\", \"Yayin_Yil\", \"Yönetmen_ID\") VALUES (@Name, @Rating, @Year, @DirectorID) RETURNING \"Film_ID\";";

                    using (var cmd = new NpgsqlCommand(insertFilmSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", Film_Ad.Text);
                        cmd.Parameters.AddWithValue("@Rating", double.Parse(Degerlendirme.Text));
                        cmd.Parameters.AddWithValue("@Year", int.Parse(Yayin_Yil.Text));
                        cmd.Parameters.AddWithValue("@DirectorID", Yonetmen.SelectedValue);

                        FilmID = (int)cmd.ExecuteScalar();

                    }

                    string insertGenreSql = "INSERT INTO public.\"Film_Tür\" (\"Film_ID\", \"Tür_ID\") VALUES (@FilmID, @TürID);";

                    foreach (var item in Tur.CheckedItems)
                    {
                        DataRowView dataRowView = item as DataRowView;
                        using (var cmd = new NpgsqlCommand(insertGenreSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FilmID", FilmID);
                            cmd.Parameters.AddWithValue("@TürID", (int)dataRowView["Tür_ID"]);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    string insertActorSql = "INSERT INTO public.\"Film_Aktör\" (\"Film_ID\", \"Aktör_ID\") VALUES (@FilmID, @AktörID);";

                    foreach (var item in Oyuncular.CheckedItems)
                    {
                        DataRowView dataRowView = item as DataRowView;
                        using (var cmd = new NpgsqlCommand(insertActorSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FilmID", FilmID);
                            cmd.Parameters.AddWithValue("@AktörID", (int)dataRowView["Aktör_ID"]);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                }
            }
            UpdateDataGridView();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                var deleteFilmActorSql = "DELETE FROM public.\"Film_Aktör\" WHERE \"Film_ID\" = @FilmID;";
                var cmdFilmActor = new NpgsqlCommand(deleteFilmActorSql, conn);
                cmdFilmActor.Parameters.AddWithValue("@FilmID", Convert.ToInt32(Film_ID.Text));
                cmdFilmActor.ExecuteNonQuery();

                var deleteFilmGenreSql = "DELETE FROM public.\"Film_Tür\" WHERE \"Film_ID\" = @FilmID;";
                var cmdFilmGenre = new NpgsqlCommand(deleteFilmGenreSql, conn);
                cmdFilmGenre.Parameters.AddWithValue("@FilmID", Convert.ToInt32(Film_ID.Text));
                cmdFilmGenre.ExecuteNonQuery();

                var deleteFilmSql = "DELETE FROM public.\"Film\" WHERE \"Film_ID\" = @FilmID;";
                var cmdFilm = new NpgsqlCommand(deleteFilmSql, conn);
                cmdFilm.Parameters.AddWithValue("@FilmID", Convert.ToInt32(Film_ID.Text));

                var rowsAffected = cmdFilm.ExecuteNonQuery();

                transaction.Commit();

            }
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var da = new NpgsqlDataAdapter("SELECT * FROM public.\"FilmDetails\"", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
