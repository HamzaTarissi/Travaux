using System.Data;
using System.Data.SqlClient;

namespace Dbfilmconnec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttinsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Film values (@ID,@Name)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void buttupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Declare @Id_film INT"+"Update Film set Name=@Nom_film where Id=@Id_film)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void buttdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Film where Id=@Id_film)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void buttselect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Film ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}