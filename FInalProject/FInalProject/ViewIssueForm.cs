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
    public partial class ViewIssueForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PTI739J\KHANHTRAN;Initial Catalog=FinalLibrary;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public ViewIssueForm()
        {
            InitializeComponent();
            LoadStatus();
        }

        private void dgvBookStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBookStatus.Columns[e.ColumnIndex].Name;
            if (colName == "Return")
            {
                ReturnBookForm rt = new ReturnBookForm();
                rt.txtID.Text = dgvBookStatus.Rows[e.RowIndex].Cells[0].Value.ToString();
                rt.txtSID.Text = dgvBookStatus.Rows[e.RowIndex].Cells[1].Value.ToString();
                rt.txtSName.Text = dgvBookStatus.Rows[e.RowIndex].Cells[2].Value.ToString();
                rt.txtFaculty.Text = dgvBookStatus.Rows[e.RowIndex].Cells[3].Value.ToString();
                rt.txtSPhone.Text = dgvBookStatus.Rows[e.RowIndex].Cells[4].Value.ToString();
                rt.txtSEmail.Text = dgvBookStatus.Rows[e.RowIndex].Cells[5].Value.ToString();
                rt.txtBookID.Text = dgvBookStatus.Rows[e.RowIndex].Cells[6].Value.ToString();
                rt.txtBookName.Text = dgvBookStatus.Rows[e.RowIndex].Cells[7].Value.ToString();

                
                rt.ShowDialog();
                LoadStatus();
            }
        }
        public void LoadStatus()
        {

            dgvBookStatus.Rows.Clear();
            cmd = new SqlCommand("Select * from IRBook", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                dgvBookStatus.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());

            }
            reader.Close();
            con.Close();
        }
    }
}
