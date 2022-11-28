using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnecToDBFilm
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
        private void buttselect_Click(object sender, EventArgs e)
        {
            string connstring = "Data source  = PC-HAMZA;Initial Catalog = Film; Integrated Security = True";
            SqlConnection con = new SqlConnection(chaine);
            con.Open();
            string query = "select * from Film";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string output = "output = " + reader.GetValue(0) + "-" + reader.GetValue(1);
                MessageBox.Show(output);  
            }

        }
    }
}