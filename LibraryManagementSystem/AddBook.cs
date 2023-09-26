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
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtbookAuthorName.Text != "" && txtBookPublication.Text != "" && txtbookPrise.Text != "" && txtbookQuantity.Text != "")
            {
                String bName = txtBookName.Text;
                String bAuthor = txtbookAuthorName.Text;
                String bPubl = txtBookPublication.Text;
                String bPDate = txtPookPurchaseDate.Text;
                Int64 bPrice = Int64.Parse(txtbookPrise.Text);
                Int64 bQuan = Int64.Parse(txtbookQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB; database=bookLibrary; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName, bAuthor, bPubl, bPDate, bPrice, bQuan) values ('" + bName + "', '" + bAuthor + "', '" + bPubl + "', '" + bPDate + "', " + bPrice + ", " + bQuan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookName.Clear();
                txtbookAuthorName.Clear();
                txtBookPublication.Clear();
                txtbookPrise.Clear();
                txtbookQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty textboxes are not Allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? This will delete your unsaved data", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
