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

namespace ExamQcm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttnext_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=PC-HAMZA;Initial Catalog=Question;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into qcm(question,answer1,answer2,answer3,correctanswer)values('"+ textQuestion +"','"+ textOption1 + "','"+ textOption2 + "','"+ textOption3 + "','"+ textAnswer + "' ", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show(i + "Question saved");
            }
            con.Close();
            textQuestion.Clear();
            textOption1.Clear();
            textOption2.Clear();
            textOption3.Clear();
        }
    }
}
