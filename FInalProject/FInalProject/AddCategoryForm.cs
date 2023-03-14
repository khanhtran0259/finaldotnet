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
    public partial class AddCategoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this Category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO Category(Category) VALUES( @CaName)", con);
                    
                    cmd.Parameters.AddWithValue("@CaName", txtCategory.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been successfully saved!");
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
            
            txtCategory.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your Data is not saved!", "Are you want to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
