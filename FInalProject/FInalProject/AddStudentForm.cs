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
    public partial class AddStudentForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        OpenFileDialog openFileDialog;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this Book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO Student values(@SID,@SName,@SFaculty, @SSemester, @SPhone,@SEmail, @image)", con);
                    cmd.Parameters.AddWithValue("@SID", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@SName", txtStudentName.Text);
                    cmd.Parameters.AddWithValue("@SFaculty", txtFaculty.Text);
                    cmd.Parameters.AddWithValue("@SSemester", txtSemester.Text);
                    cmd.Parameters.AddWithValue("@SPhone", txtStudentPhone.Text);
                    cmd.Parameters.AddWithValue("@SEmail", txtStudentEmail.Text);
                    cmd.Parameters.AddWithValue("@image", openFileDialog.FileName);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book has been successfully added!");
                    Clear_Form();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear_Form()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtFaculty.Clear();
            txtSemester.Clear();
            txtStudentPhone.Clear();
            txtStudentEmail.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your Data is not saved!", "Are you want to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to update this student?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Update Student Set StudentName=@SName, Faculty=@Faculty, Semester=@Semester, Phone=@Phone, Email=@Email, Image=@Image where StudentID like '" + txtStudentID.Text + "'", con);

                    cmd.Parameters.AddWithValue("@SName", txtStudentName.Text);
                    cmd.Parameters.AddWithValue("@Faculty", txtFaculty.Text);
                    cmd.Parameters.AddWithValue("@Semester", txtSemester.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtStudentPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtStudentEmail.Text);
                    cmd.Parameters.AddWithValue("@Image", openFileDialog.FileName);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully updated!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select imgae(*.Jpg, *.png, *.Gif)|*.Jpg;*.png;*.Gif ";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
               Bitmap imgStudent = (Bitmap)Image.FromFile(openFileDialog.FileName, true);
            }
        }
    }
}
