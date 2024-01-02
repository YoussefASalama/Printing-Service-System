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
using login_form;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class frmCustomer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True");

        public void update_total()
        {
            if (txtPages.Text == string.Empty)
            {
                total = 0;
                lblTotal.Text = $"Total: {total}";
            }
            else
            {
                if (cboType.SelectedIndex == 0)
                {
                    if (cboColor.SelectedIndex == 0)
                    {
                        if (cboBinding.SelectedIndex == 0)
                        {
                            total = int.Parse(txtPages.Text) * 2 + 5;
                        }
                        else if (cboBinding.SelectedIndex == 1)
                        {
                            total = int.Parse(txtPages.Text) * 2 + 15;
                        }
                    }
                    else if (cboColor.SelectedIndex == 1)
                    {
                        if (cboBinding.SelectedIndex == 0 && int.Parse(txtPages.Text) < 100)
                        {
                            total = int.Parse(txtPages.Text) * 1 + 5;
                        }
                        else if (cboBinding.SelectedIndex == 1 && int.Parse(txtPages.Text) < 100)
                        {
                            total = int.Parse(txtPages.Text) * 1 + 15;
                        }
                        else if (cboBinding.SelectedIndex == 0 && int.Parse(txtPages.Text) >= 100)
                        {
                            total = int.Parse(txtPages.Text) * 0.8 + 5;
                        }
                        else if (cboBinding.SelectedIndex == 1 && int.Parse(txtPages.Text) >= 100)
                        {
                            total = int.Parse(txtPages.Text) * 0.8 + 15;
                        }
                    }
                    if (cboUrgent.SelectedIndex == 0)
                    {
                        total += total * 0.3;
                    }
                    lblTotal.Text = $"Total: {total}";
                }
                else if (cboType.SelectedIndex == 1)
                {
                    total = int.Parse(txtPages.Text) * 3;
                    if (cboUrgent.SelectedIndex == 0)
                    {
                        total += total * 0.3;
                    }
                    lblTotal.Text = $"Total: {total}";
                }
                else if (cboType.SelectedIndex == 2)
                {
                    total = int.Parse(txtPages.Text) * 10;
                    if (cboUrgent.SelectedIndex == 0)
                    {
                        total += total * 0.3;
                    }
                    lblTotal.Text = $"Total: {total}";
                }
            }
        }

        public void reset_options()
        {
            if (cboType.SelectedIndex == 0)
            {
                cboBinding.Visible = true;
                cboBinding.SelectedIndex = 0;
                cboColor.Visible = true;
                cboColor.SelectedIndex = 1;
                cboUrgent.SelectedIndex = 1;
                txtPages.Text = string.Empty;
            }
            else if (cboType.SelectedIndex == 1)
            {
                cboBinding.Visible = false;
                cboBinding.SelectedIndex = -1;
                cboColor.Visible = false;
                cboColor.SelectedIndex = -1;
                cboUrgent.SelectedIndex = 1;
                txtPages.Text = string.Empty;
            }
            else if (cboType.SelectedIndex == 2)
            {
                cboBinding.Visible = false;
                cboBinding.SelectedIndex = -1;
                cboColor.Visible = false;
                cboColor.SelectedIndex = -1;
                cboUrgent.SelectedIndex = 1;
                txtPages.Text = string.Empty;
            }
        }

        public void update_table()
        {
            lsvDisplay.Clear();
            DataTable displayTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data from database to data table
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM request_table WHERE CustomerName = '{GlobalUserName.UserName}'", connection))
                {
                    adapter.Fill(displayTable);
                }
                //Create Columns
                foreach (DataColumn column in displayTable.Columns)
                {
                    lsvDisplay.Columns.Add(column.ColumnName, 80);
                }
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data to table
                foreach (DataRow row in displayTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < displayTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lsvDisplay.Items.Add(item);
                }
            }
        }

        //Initialising the array holding the types and the variable holding total
        string[] types = new[] { "Book", "Poster", "Banner" };
        double total = 0;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This is so that when the type is changed, the available options change accordingly
            reset_options();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assigning the contents of the variable array to the combo box used to change the type and then assigning the correct text to total
            for (int index = 0; index <= types.GetUpperBound(0); index++)
            {
                cboType.Items.Add(types[index]);
            }
            cboType.SelectedIndex = 0;

            cboUrgent.SelectedIndex = 1;
            lblTotal.Text = $"Total: {total}";
            lblWelcome.Text = $"Welcome,\n{GlobalUserName.UserName}.";
            update_table();
        }

        private void lblUrgent_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboBinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Calculating the total value and assigning it to the total label after the binding option is changed
            update_total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPages.Text != string.Empty)
            {
                //Adding the request to the database and resetting the options as well as showing a message box to the user showing that the process has been successful
                int requestID = 1;
                string serviceType = "";

                if (cboType.SelectedIndex == 0)
                {
                    serviceType = "Book";
                }
                else if (cboType.SelectedIndex == 1)
                {
                    serviceType = "Poster";
                }
                else if (cboType.SelectedIndex == 2)
                {
                    serviceType = "Banner";
                }
                string color = (string)cboColor.SelectedItem;
                string binding = (string)cboBinding.SelectedItem;
                string urgency = (string)cboUrgent.SelectedItem;
                int pages = int.Parse(txtPages.Text);
                DateTime dateTime = DateTime.Today;
                string date = dateTime.ToString("MM/dd/yyyy");

                using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
                {
                    connection.Open();
                    //Getting a new id that is an increment of the largest existing ID
                    using (SqlCommand command = new SqlCommand("SELECT TOP 1 RequestID FROM request_table ORDER BY RequestID DESC", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                requestID += id;
                            }
                        }
                    }
                    //Adding the record to the table
                    using (SqlCommand command = new SqlCommand($"INSERT INTO request_table (RequestID, Date, ServiceType, Pages, Color, Binding, Urgency, Status, CustomerName, WorkerName, Price) VALUES ({requestID}, '{date}', '{serviceType}', {pages}, '{color}', '{binding}', '{urgency}', 'Requested', '{GlobalUserName.UserName}', 'Not Assigned', {total})", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Request added successfully");
                reset_options();
                update_table();
            }
            else
            {
                MessageBox.Show("Please fill all the details!");
            }
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Calculating the total value and assigning it to the total label after the color option is changed
            update_total();
        }

        private void cboUrgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Calculating the total value and assigning it to the total label after the Urgent option is changed
            update_total();
        }

        private void txtPages_TextChanged(object sender, EventArgs e)
        {
            //Checks if value enetred is int and if not it clears the textbox and outputs error message
            if (!int.TryParse(txtPages.Text, out int result) && txtPages.Text != "")
            {
                MessageBox.Show("Please enter only integer values.");
                txtPages.Text = "";
            }
            //Calculating the total value and assigning it to the total label after the pages option is changed
            update_total();
        }

        private void grpAddNew_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditAccount frmEditAccount = new frmEditAccount();
            frmEditAccount.Show();
        }
    }
}
