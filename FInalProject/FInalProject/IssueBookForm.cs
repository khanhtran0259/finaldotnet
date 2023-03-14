using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class IssueBookForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public IssueBookForm()
        {
            InitializeComponent();
            LoadBook();
        }

        public void LoadBook()
        {
            cbbBookName.Items.Clear();
            cmd = new SqlCommand("Select BookName from Book", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbBookName.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("This Book will be Issued?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO IRBook(SID,	SName,	SFaculty,	SPhone,	SEmail,	BookID,	BookName,	DayIssue) VALUES(@SID, @SName, @SFaculty, @SPhone, @SEmail, @BookID, @BookName, @DayIssue)", con);
                    cmd.Parameters.AddWithValue("@SID", txtSID.Text);
                    cmd.Parameters.AddWithValue("@SName", txtSName.Text);
                    cmd.Parameters.AddWithValue("@SFaculty", txtFaculty.Text);
                    cmd.Parameters.AddWithValue("@SPhone", txtSPhone.Text);
                    cmd.Parameters.AddWithValue("@SEmail", txtSEmail.Text);
                    cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                    cmd.Parameters.AddWithValue("@BookName", cbbBookName.Text);
                    cmd.Parameters.AddWithValue("@DayIssue", dtpIssue.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book has been Issued!");
                    Clear_form();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void txtSName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadDataByID()
        {
            cmd = new SqlCommand("Select StudentName, Faculty, Phone, Email, Image from Student where StudentID= @SID", con);
            cmd.Parameters.AddWithValue("@SID", txtSID.Text);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtSName.Text = reader.GetValue(0).ToString();
                txtFaculty.Text = reader.GetValue(1).ToString();
                txtSPhone.Text  = reader.GetValue(2).ToString();
                txtSEmail.Text = reader.GetValue(3).ToString();
                imgStudent.Image = Image.FromFile(reader.GetValue(4).ToString());
                
            }
            
            
            con.Close();
        }
        public void LoadBookID()
        {
            cmd = new SqlCommand("Select BookID from Book where BookName=@BName", con);
            cmd.Parameters.AddWithValue("@BName", cbbBookName.Text);
            con.Open();
         
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtBookID.Text = reader.GetValue(0).ToString();
            
            }
            con.Close();
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {
            LoadDataByID();
        }

        private void cbbBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBookID();
        }
    }
}
