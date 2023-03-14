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
    public partial class ViewBookForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public ViewBookForm()
        {
            InitializeComponent();
            LoadBook();
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            LoadBook();
        }
        public void LoadBook()
        {
            int i = 0;
            dgvBook.Rows.Clear();
            cmd = new SqlCommand("Select * from Book where concat(BookName, Author, BookID, PurchaseDate, Publication) like '%" + txtSearchBook.Text + "%'", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                dgvBook.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString());

            }
            reader.Close();
            con.Close();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBook.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AddBookForm addBookForm = new AddBookForm();
                addBookForm.txtBookCode.Text = dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                addBookForm.txtBookName.Text = dgvBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                addBookForm.txtAuthor.Text = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                addBookForm.txtPublication.Text = dgvBook.Rows[e.RowIndex].Cells[3].Value.ToString();
                addBookForm.cbbCategory.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();
                addBookForm.dtpPurchase.Text = dgvBook.Rows[e.RowIndex].Cells[5].Value.ToString();
                addBookForm.txtBookPrice.Text = dgvBook.Rows[e.RowIndex].Cells[6].Value.ToString();
                addBookForm.txtBookQuantity.Text = dgvBook.Rows[e.RowIndex].Cells[7].Value.ToString();

                addBookForm.btnAdd.Enabled = false;
                addBookForm.btnUpdate.Enabled = true;
                addBookForm.txtBookCode.Enabled = false;
                addBookForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from Book where BookID like '" + dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }

            }
            LoadBook();
        }
    }
}
