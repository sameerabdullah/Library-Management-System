using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\USERS\USER\DOCUMENTS\LIBRARY.MDF;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Book_Record where Book_name ='" + textBox1.Text + "' and Author_name = '" + textBox2.Text + " ';", con);
            SqlCommand cmd= new SqlCommand("update Book_Record set Return_date='" + this.dateTimePicker1.Text + "' where Book_name='" + this.textBox1.Text + "' ;", con);
            SqlDataReader myReader;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("RETURNED");

                while (myReader.Read())
                {

                }
            }
            else
            {
                MessageBox.Show("BOOK NOT ISSUED TO ANYONE");
            }
        }
    }
}
