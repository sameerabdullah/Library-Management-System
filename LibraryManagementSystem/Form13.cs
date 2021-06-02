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
    public partial class Form13 : Form
    {
        public Form13()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\USERS\USER\DOCUMENTS\LIBRARY.MDF;Integrated Security=True;Connect Timeout=30;");
            SqlCommand cmd = new SqlCommand("insert into Book_Record (Book_name,Author_name,Issued_to,Issue_date) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox4.Text + "','" + this.dateTimePicker1.Text + "') ;", con);
            SqlDataReader myReader;

                try
                {
                con.Open();
                myReader = cmd.ExecuteReader();

                myReader.Close();



                MessageBox.Show("ISSUED");


            }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
