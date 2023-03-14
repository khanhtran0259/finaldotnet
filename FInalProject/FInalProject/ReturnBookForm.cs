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
    public partial class ReturnBookForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public ReturnBookForm()
        {
            InitializeComponent();
        }
        
        public void Clear_form()
        {
            txtBookID.Clear();
            txtSName.Clear();
            txtFaculty.Clear();
            txtSPhone.Clear();
            txtSEmail.Clear();
            txtSID.Clear();
        }
        public void LoadDataByID()
        {
            cmd = new SqlCommand("Select StudentName, Faculty, Phone, Email from Student where StudentID= @SID", con);
            cmd.Parameters.AddWithValue("@SID", txtSID.Text);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtSName.Text = reader.GetValue(0).ToString();
                txtFaculty.Text = reader.GetValue(1).ToString();
                txtSPhone.Text = reader.GetValue(2).ToString();
                txtSEmail.Text = reader.GetValue(3).ToString();
            }
            con.Close();
        }
       

        private void btnIssue_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("This Book will be Issued?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Update  IRBook set DayReturn=@DayReturn where Id=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                   
                    cmd.Parameters.AddWithValue("@DayReturn", dtpReturn.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book has been Returned!");
                    Clear_form();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {
            LoadDataByID();
        }

        private void cbbBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
