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

namespace FInalProject
{
    public partial class LoginForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd= new SqlCommand();
        SqlDataReader reader;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from Users where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("WelCome", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DashBoardForm main = new DashBoardForm();
                    
                    main.ShowDialog();
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
