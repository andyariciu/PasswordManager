using System;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace PasswordManager
{
    class Userdata
    {
        
        public void SaveData(string username, string password, string application)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PasswordManager.Properties.Settings.pwManagerDBConnectionString"].ConnectionString;
            //string sqlAddQuery = "INSERT INTO dbo.userDetails (userName, password, application) VALUES (" + "'" + textBoxUser.Text + "'" + "," + "'" + textBoxPW.Text + "'" + "," + "'" + TextBoxLocation.Text + "'" + ")";
            string sqlAddQuery = "INSERT INTO dbo.userDetails (userName, password, application) VALUES (@username, @password, @application)";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand(sqlAddQuery, con);

                var usernameParameter = new SqlParameter("username", System.Data.SqlDbType.VarChar);
                usernameParameter.Value = username;
                sc.Parameters.Add(usernameParameter);

                var passwordParameter = new SqlParameter("password", System.Data.SqlDbType.VarChar);
                passwordParameter.Value = password;
                sc.Parameters.Add(passwordParameter);

                var applicationParameter = new SqlParameter("application", System.Data.SqlDbType.VarChar);
                applicationParameter.Value = application;
                sc.Parameters.Add(applicationParameter);

                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Username and password have been saved!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteData(string userID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PasswordManager.Properties.Settings.pwManagerDBConnectionString"].ConnectionString;
            string sqlDeleteQuery = "DELETE FROM dbo.userDetails WHERE userID=" + userID;
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand(sqlDeleteQuery, con);

                var userIDParameter = new SqlParameter("userID", System.Data.SqlDbType.VarChar);
                userIDParameter.Value = userID;
                sc.Parameters.Add(userIDParameter);

                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The selected data has been removed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangeData(string userID, string newPassword)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PasswordManager.Properties.Settings.pwManagerDBConnectionString"].ConnectionString;
            string sqlUpdateQuery = "UPDATE dbo.userDetails" + " " +
                                    "SET password=" + "'" + newPassword + "'" + 
                                    "WHERE userID=@userId";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand(sqlUpdateQuery, con);

                var userIDParameter = new SqlParameter("userID", System.Data.SqlDbType.VarChar);
                userIDParameter.Value = userID;
                sc.Parameters.Add(userIDParameter);

                var passwordParameter = new SqlParameter("newPassword", System.Data.SqlDbType.VarChar);
                passwordParameter.Value = newPassword;
                sc.Parameters.Add(passwordParameter);

                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The password has been changed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string userName { get; set; }
        public string password { get; set; }
        public string application { get; set; }
        public string userID { get; set; }

    }
}
