using login_form;
using Registration;
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

namespace Report_Income
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        public void update_table()
        {
            lsvDisplay.Clear();
            DataTable displayTable = new DataTable();
            string month = comboBox1.Text;
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data from database to data table
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM request_table WHERE MONTH(Date) = {month}", connection))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVReport_Click(object sender, EventArgs e)
        {
                update_table();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string selectQuery = "SELECT SUM(Price) AS PriceTotal FROM request_table WHERE MONTH(Date) = @Month;";
            //@Month serves as a placeholder for later assignment to a value
            string month = comboBox1.Text;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a month to generate Income!");

            }
            else
            {
                //I used the 'using...' format so i dont have to close the connection everytime.
                using (SqlConnection conn = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        //AddWithValue was used here so as to use placeholders in teh SQL Query then later assign values to it as done below with month.
                        cmd.Parameters.AddWithValue("@Month", month);

                        //ExecuteScalar() was used here to retrieve a single value which is the sum of the selected column.
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            // Convert the retrieved value to decimal and store in a variable
                            decimal totalIncome = Convert.ToDecimal(result);
                            lblTotalPrice.Text = "RM " + totalIncome.ToString("F2");
                            // Display or process the total income for the specified month
                        }
                        else
                        {
                            MessageBox.Show("No data in selected Month.");
                            // No income data for the specified month found
                        }
                    }
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmRegistration form = new frmRegistration();
            form.Show();
            this.Hide();
        }

        private void lsvDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
