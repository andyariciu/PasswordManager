using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        //string connectionString = "Server=ANDY\\SQLEXPRESS;Database=pwManagerDB;Trusted_Connection=True;TrustServerCertificate=True";     
        public Form1()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PasswordManager.Properties.Settings.pwManagerDBConnectionString"].ConnectionString;
            InitializeComponent();
            FormPassword formPass = new FormPassword();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            try 
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" || textBoxPW.Text != "")
            {
                SaveData();
                refresh();
            }
            else
                MessageBox.Show("Error! Please insert both username and password!");
        }

        void SaveData()
        {
            string username = textBoxUser.Text;
            string password = textBoxPW.Text;
            string application = TextBoxLocation.Text;
            Userdata user = new Userdata();
            user.SaveData(username, password, application);
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.userDetailsTableAdapter.Fill(this.pwManagerDBDataSet.userDetails);
            timer1.Start();
        }

        void DeleteData()
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string userID = Convert.ToString(selectedRow.Cells["userIDDataGridViewTextBoxColumn"].Value);
            Userdata user = new Userdata();
            user.DeleteData(userID);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Do you want to delete this row from database?", dataGridView1.SelectedCells[0].Value),"Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                DeleteData();
                refresh();
            }
        }
        public void ChangeData()
        {
            FormPassword formPass = new FormPassword();
            formPass.ShowDialog();
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string userID = Convert.ToString(selectedRow.Cells["userIDDataGridViewTextBoxColumn"].Value);
            string newPassword = formPass.textBoxNewPassword.Text;
            Userdata user = new Userdata();
            user.ChangeData(userID, newPassword);
            formPass.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            ChangeData();
            refresh();
        }
        public void refresh()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PasswordManager.Properties.Settings.pwManagerDBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string databaseInfo = "select * from dbo.userDetails";
            SqlDataAdapter SDA = new SqlDataAdapter(databaseInfo, con);
            System.Data.DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "dbo.userDetails");
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }
    }
}
