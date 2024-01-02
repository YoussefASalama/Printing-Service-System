using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using login_form;

namespace Registration
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (emailTxtBox.Text!=String.Empty && textBox3.Text!= String.Empty && PasswordTxtBox.Text!=String.Empty && RoleComboBox.SelectedItem.ToString() !=String.Empty && nameTxtBox.Text != String.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True");
                conn.Open();
                using (SqlCommand command = new SqlCommand($"INSERT INTO login_table (UserName, Password, Role, Email, Name) VALUES ('{textBox3.Text}', '{PasswordTxtBox.Text}', '{RoleComboBox.SelectedItem}', '{emailTxtBox.Text}', '{nameTxtBox.Text}');", conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Registered Successfully");
                emailTxtBox.Clear();
                textBox3.Clear();
                PasswordTxtBox.Clear();
                nameTxtBox.Clear();
                RoleComboBox.SelectedIndex = -1;
            }
            else
            {
                //Display a message if a required field is empty.
                MessageBox.Show("Please check entries again!");
            }
            
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
