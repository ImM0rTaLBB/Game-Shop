using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShopDB
{
    public partial class Login : Form
    {
        Point LastClick;
        OleDbConnection connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastClick.X;
                this.Top += e.Y - LastClick.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:/DB Project/ShopDB/ShopDB/Shop.accdb;
Persist Security Info=False;";
                connection.Open();
                checkConnection.Text = "Connection Successful";
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed" + ex);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Profile where C_ID='" + txtUsername.Text + "' and C_Password= '" + txtPassword.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "123")
                {
                    MessageBox.Show("Admin logged in");
                    txtUsername.Focus();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    ShopManager SM = new ShopManager();
                    UserManager UM = new UserManager();
                    SM.Show();
                    UM.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password is correct");
                    connection.Close();
                    connection.Dispose();
                    this.Hide();
                    Shop s = new Shop();
                    s.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Username and Password is incorrect");
            }
            connection.Close();
        }
    }
}
