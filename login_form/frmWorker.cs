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
    public partial class frmWorker : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True");

        public frmWorker()
        {
            InitializeComponent();
        }

        public void update_table()
        {
            lsvDisplay.Clear();
            DataTable displayTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data from database to data table
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM request_table WHERE WorkerName = '{GlobalUserName.UserName}'", connection))
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


        private void Form2_Load(object sender, EventArgs e)
        {
            update_table();
            label1.Text = $"Welcome, {GlobalUserName.UserName}.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CompleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRequestID.Text);
            con.Open();
            using (SqlCommand cmd2 = new SqlCommand($"UPDATE request_table SET Status = 'Completed' WHERE RequestID = {id};", con))
            {
                cmd2.ExecuteNonQuery();
            }
            update_table();
            txtRequestID.Text = string.Empty;
            con.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void lsvDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            frmEditAccount frmEditAccount = new frmEditAccount();
            frmEditAccount.Show();
        }
    }
}
