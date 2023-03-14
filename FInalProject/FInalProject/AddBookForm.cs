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
    
    public partial class AddBookForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public AddBookForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this Book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO Book VALUES(@BCode,@BName, @BAuthor, @BPublic,@Category,@BPurchase, @BPrice , @BQuantity)", con);
                    cmd.Parameters.AddWithValue("@BCode", txtBookCode.Text);
                    cmd.Parameters.AddWithValue("@BName", txtBookName.Text);
                    cmd.Parameters.AddWithValue("@BAuthor", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@BPublic", txtPublication.Text);
                    cmd.Parameters.AddWithValue("@Category", cbbCategory.Text);
                    cmd.Parameters.AddWithValue("@BPurchase", dtpPurchase.Value);
                    cmd.Parameters.AddWithValue("@BPrice", Convert.ToInt32(txtBookPrice.Text));
                    cmd.Parameters.AddWithValue("@BQuantity", txtBookQuantity.Text);
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
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtBookPrice.Clear();
            txtBookQuantity.Clear();
            txtBookCode.Clear();
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
                if (MessageBox.Show("Are you want to update this book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Update Book Set BookName=@BookName, Author=@Author, Publication=@Publication, PurchaseDate=@PurchaseDate, Price=@Price, Quantity=@Quantity where BookID like '" + txtBookCode.Text + "'", con);

                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Publication", txtPublication.Text);
                    cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchase.Value);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(txtBookPrice.Text));
                    cmd.Parameters.AddWithValue("@Quantity", txtBookQuantity.Text);



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

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadCategory()
        {
            cbbCategory.Items.Clear();
            cmd = new SqlCommand("Select Category from Category", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbCategory.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();
        }
    }
}
