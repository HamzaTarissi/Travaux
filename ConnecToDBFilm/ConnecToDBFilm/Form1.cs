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

        private void buttselect_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Film",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);   
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void buttinsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Film values (@Id_film,@Nom_film)",con);
            cmd.Parameters.AddWithValue("@Id_film", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nom_film",(textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void buttupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Film set Film Name=@Nom_film where Film ID=@Id_film",con);
            cmd.Parameters.AddWithValue("@Id_film", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nom_film", (textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void buttdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Film where Film ID=@Id_film", con);
            cmd.Parameters.AddWithValue("@Id_film",int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}