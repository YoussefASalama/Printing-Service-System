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
    public partial class frmManager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        public frmManager()
        {
            InitializeComponent();
        }

        public void update_table()
        {
            lvRequest.Clear();
            DataTable displayTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data from database to data table
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT RequestID, ServiceType, Status, WorkerName FROM request_table ", connection))
                {
                    adapter.Fill(displayTable);
                }
                //Create Columns
                foreach (DataColumn column in displayTable.Columns)
                {
                    lvRequest.Columns.Add(column.ColumnName, 80);
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
                    lvRequest.Items.Add(item);
                }
            }
        }

        public void update_table_2()
        {
            lvWorker.Clear();
            DataTable displayTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data from database to data table
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT UserName FROM login_table WHERE Role = 'Worker' ", connection))
                {
                    adapter.Fill(displayTable);
                }
                //Create Columns
                foreach (DataColumn column in displayTable.Columns)
                {
                    lvWorker.Columns.Add(column.ColumnName, 80);
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
                    lvWorker.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            update_table();
            update_table_2();
            label3.Text = $"Welcome, {GlobalUserName.UserName}.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxRequest.Text);
            var name = textBoxWorker.Text;
            con.Open();
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=Ibra;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                //Add data from database to data table
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT UserName FROM login_table WHERE Role = 'Worker' ", connection))
                {
                    adapter.Fill(dt);
                }
            }
            bool isAvaible = false;
            foreach (DataRow row in dt.Rows)
            {
                if (name == row[0].ToString())
                {
                    isAvaible = true; break;
                }
            }

            if (isAvaible)
            {
                using (SqlCommand cmd2 = new SqlCommand($"UPDATE request_table SET WorkerName = '{name}' WHERE RequestID = {id};", con))
                {
                    cmd2.ExecuteNonQuery();
                }
                update_table();
                update_table_2();
                textBoxWorker.Text = string.Empty;
                isAvaible = false;
            } else
            {
                MessageBox.Show("Worker not Availabe");
                textBoxWorker.Text = string.Empty;
            }
                
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEditAccount frmEditAccount = new frmEditAccount();
            frmEditAccount.Show();
        }
    }
}
