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
    public partial class ViewStudentForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public ViewStudentForm()
        {
            InitializeComponent();
            LoadStudent();
        }
        public void LoadStudent()
        {
            
            dgvStudent.Rows.Clear();
            cmd = new SqlCommand("Select * from Student where concat(StudentID,StudentName, Faculty, Phone, Email) like '%" + txtSearchStudent.Text + "%'", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                dgvStudent.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

            }
            reader.Close();
            con.Close();
        }

        

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void dgvStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStudent.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AddStudentForm addStudentForm = new AddStudentForm();
                addStudentForm.txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                addStudentForm.txtStudentName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                addStudentForm.txtFaculty.Text = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                addStudentForm.txtSemester.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                addStudentForm.txtStudentPhone.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                addStudentForm.txtStudentEmail.Text = dgvStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                addStudentForm.btnAdd.Enabled = false;
                addStudentForm.btnUpdate.Enabled = true;
                addStudentForm.txtStudentID.Enabled = false;
                addStudentForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from Student where StudentID like '" + dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }

            }
            LoadStudent();
        }
    }
}
