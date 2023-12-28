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
using System.Xml.Linq;

namespace cinema
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private string _connectionString = "server=localHost; port=5432; Database=cinema; user ID=postgres; password=2220172";
        private void find_Click(object sender, EventArgs e)
        {
            string movieName = Film_Ad.Text.Trim();
            string yearStart = Yayin_Yil.Text.Trim();
            string yearEnd = Yayin_Yil2.Text.Trim();
            string imdbStart = Degerlendirme.Text.Trim();
            string imdbEnd = Degerlendirme2.Text.Trim();

            NpgsqlConnection conn = new NpgsqlConnection(_connectionString);
            StringBuilder queryBuilder = new StringBuilder();

            queryBuilder.Append("SELECT * FROM public.\"Film\" WHERE \"Film_Ad\" ILIKE @name");

            if (!string.IsNullOrEmpty(yearStart))
            {
                queryBuilder.Append(" AND \"Yayin_Yil\" >= @yearStart");
            }
            if (!string.IsNullOrEmpty(yearEnd))
            {
                queryBuilder.Append(" AND \"Yayin_Yil\" <= @yearEnd");
            }
            if (!string.IsNullOrEmpty(imdbStart))
            {
                queryBuilder.Append(" AND \"Degerlendirme\" >= @imdbStart");
            }
            if (!string.IsNullOrEmpty(imdbEnd))
            {
                queryBuilder.Append(" AND \"Degerlendirme\" <= @imdbEnd");
            }

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(queryBuilder.ToString(), conn);

            cmd.Parameters.AddWithValue("@name", "%" + movieName + "%");

            if (!string.IsNullOrEmpty(yearStart))
            {
                cmd.Parameters.AddWithValue("@yearStart", int.Parse(yearStart));
            }
            if (!string.IsNullOrEmpty(yearEnd))
            {
                cmd.Parameters.AddWithValue("@yearEnd", int.Parse(yearEnd));
            }
            if (!string.IsNullOrEmpty(imdbStart))
            {
                cmd.Parameters.AddWithValue("@imdbStart", double.Parse(imdbStart));
            }
            if (!string.IsNullOrEmpty(imdbEnd))
            {
                cmd.Parameters.AddWithValue("@imdbEnd", double.Parse(imdbEnd));
            }

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }
    }
}
