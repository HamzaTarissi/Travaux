using System.Data;
using System.Data.SqlClient;

namespace MoviedbConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttselect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Movies;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Movie ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttinsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Movies;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Movie values (@id,@Nom)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@nom", (textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void buttupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Movies;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Movie set nom = @nom where id = @id)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@nom", (textBox2.Text));
            cmd.ExecuteNonQuery();    
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void buttdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Movies;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Movie where id=@id)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }
    }
}