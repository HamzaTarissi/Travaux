using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectoDBFilm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string chaine = "Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True";

        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);


        private void buttselect_Click_1(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from film";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void buttinsert_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into film(Id_film, Nom_film) values('" + txtNom_film + "','" + txtId_film + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void buttupdate_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update film set Id_film='" + txtId_film + "' where Id_film='" + txtId_film + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void buttdelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from film where Id_film='" + txtId_film + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

    }
}