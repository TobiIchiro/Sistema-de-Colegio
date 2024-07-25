using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
using System.Xml.Linq;

public class UserMethods
{
    private MainConnection mainConnection = new MainConnection();
    public void SaveUser(string name, string lastName1, string lastName2, string loginUser, string password)
    {
        try
        {
            SqlCommand command;
            mainConnection.open();
            command = new SqlCommand("insert_user", mainConnection.connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@LastName1", lastName1);
            command.Parameters.AddWithValue("@LastName2", lastName2);
            command.Parameters.AddWithValue("@LoginUser", loginUser);
            command.Parameters.AddWithValue("@PasswordUser", password);
            command.ExecuteNonQuery();
            mainConnection.close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        
    }
    public void ShowUsers(/*DataGridView dataGridView*/)
    {
        DataTable dataTable = new DataTable();
        SqlDataAdapter adapter;
        try
        {
            mainConnection.open();
            adapter = new SqlDataAdapter("show_user", mainConnection.connection);
            adapter.Fill(dataTable);
            /*dataGridView.DataSource = dataTable;*/
            mainConnection.close();
        }
        catch (Exception ex)
        { 
            MessageBox.Show(ex.Message);
        }

    }
    public void UpdateUser(int id, string name, string lastName1, string lastName2, string loginUser, string password)
    {
        try
        {
            SqlCommand command;
            mainConnection.open();
            command = new SqlCommand("update_user", mainConnection.connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@LastName1", lastName1);
            command.Parameters.AddWithValue("@LastName2", lastName2);
            command.Parameters.AddWithValue("@LoginUser", loginUser);
            command.Parameters.AddWithValue("@PasswordUser", password);
            command.ExecuteNonQuery();
            mainConnection.close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public void DeleteUser(int id)
    {
        try
        {
            SqlCommand command;
            mainConnection.open();
            command = new SqlCommand("delete_user", mainConnection.connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            mainConnection.close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}

