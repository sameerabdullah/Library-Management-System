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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            checkBox1.Parent = pictureBox1;
            checkBox1.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\USERS\USER\DOCUMENTS\LIBRARY.MDF;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Login where Password ='" + textBox2.Text + "'", con);
            SqlCommand cmd= new SqlCommand("update Login set username='" + this.textBox1.Text + "' where password='" + this.textBox2.Text + "' ;", con);
            SqlDataReader myReader;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("SAVED");

                while (myReader.Read())
                {

                }
            }
            else
            {
                MessageBox.Show("INCORRECT PASSWORD");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
