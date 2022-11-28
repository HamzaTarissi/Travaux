using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConecDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=PC-HAMZA;Initial Catalog=Film;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Film values (@ID,@Name)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved");
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttselect_Click(object sender, EventArgs e)
        {

        }
    }
}
