using System.Data.SqlClient;

namespace DataBaseFilmConnectivity
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
            SqlCommand cmd = new SqlCommand("insert into Film values (@ID,@Name)",con);
            cmd.Parameters.AddWithValue("@ID",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name",(textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }
    }
}