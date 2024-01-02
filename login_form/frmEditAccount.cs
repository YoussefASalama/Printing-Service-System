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

namespace login_form
{
    public partial class frmEditAccount : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        public frmEditAccount()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEditAccount_Load(object sender, EventArgs e)
        {
            DataTable informationTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data from database to data table
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM login_table WHERE UserName = '{GlobalUserName.UserName}'", connection))
                {
                    adapter.Fill(informationTable);
                }
            }
            //Add data to text boxes
            txtUserName.Text = informationTable.Rows[0][0].ToString();
            txtPassword.Text = informationTable.Rows[0][1].ToString();
            txtEmail.Text = informationTable.Rows[0][3].ToString();
            txtName.Text = informationTable.Rows[0][4].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            using (SqlCommand cmd = new SqlCommand($"UPDATE login_table SET UserName = '{txtUserName.Text}', Password = '{txtPassword.Text}', Email = '{txtEmail.Text}', Name = '{txtName.Text}' WHERE UserName = '{GlobalUserName.UserName}'", connection))
            {
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Updated successfully.");
            connection.Close();
            this.Close();
        }
    }
}
