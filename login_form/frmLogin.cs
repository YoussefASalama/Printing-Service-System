using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Assignment;
using Registration;
using Report_Income;

namespace login_form
{
    public partial class frmLogin : Form
    {
        public string userName, userPassword;

        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True");

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != String.Empty && txtUserName.Text != String.Empty) 
            { 
                userName = txtUserName.Text;
                userPassword = txtPassword.Text;

                //Assigning the username to a global variable to be able to use it in other forms
                GlobalUserName.UserName = userName;

                try
                {
                    String querry1 = $"SELECT * FROM login_table WHERE UserName = '{userName}' AND Password = '{userPassword}'";
                    SqlDataAdapter sda1 = new SqlDataAdapter(querry1, conn);
                    String querry2 = $"SELECT Role FROM login_table WHERE UserName = '{userName}' AND Password = '{userPassword}'";
                    SqlDataAdapter sda2 = new SqlDataAdapter(querry2, conn);

                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);

                    string role = dt2.Rows[0]["Role"].ToString();

                    if (dt1.Rows.Count > 0)
                    {
                        if (role == "Admin")
                        {
                            frmAdmin form = new frmAdmin();
                            form.Show();
                            this.Hide();
                        }
                        else if (role == "Manager")
                        {
                            frmManager form = new frmManager();
                            form.Show();
                            this.Hide();
                        }
                        else if (role == "Customer")
                        {
                            frmCustomer form = new frmCustomer();
                            form.Show();
                            this.Hide();
                        }
                        else if (role == "Worker")
                        {
                            frmWorker form = new frmWorker();
                            form.Show();
                            this.Hide();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid login details!");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all of the details!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
