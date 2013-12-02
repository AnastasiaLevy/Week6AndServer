using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for ServiceLayer
/// </summary>
public class ServiceLayerPerson
{ 
     string ConnString = ConfigurationManager.ConnectionStrings["ClassProjectDataBaseEntities"].ConnectionString;
    
    public ServiceLayerPerson()
    {

    }
    public int ReturnCount()
    {

        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "SELECT count (*) from People";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        sqlConnection.Open();
        int count = Convert.ToInt32(command.ExecuteScalar());
        sqlConnection.Close();
        return count;
    }

    public DataTable ReturnFullList()
    {
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "SELECT FirstName, LastName, schedule  FROM People p JOIN Labs l on p.LabId = l.id;";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        sqlConnection.Open();
        DataTable fullSet = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(fullSet);
        da.Dispose();
        sqlConnection.Close();
        return fullSet;
    }

    public DataTable FindPersonById(int id)
    {
        
        string strConnection = ConfigurationManager.ConnectionStrings["ClassProjectDataBaseEntities"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "SELECT FirstName, LastName, schedule FROM People JOIN Labs l on people.LabId = l.id WHERE people.id = @id";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@id", id));
        sqlConnection.Open();
        DataTable person = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(person);
        da.Dispose();
        sqlConnection.Close();
        return person;
    }

    public int FindIdByUsername(string username)
    {
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "SELECT id from people where username = @username";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@username", username));
        sqlConnection.Open();
       int id =  Convert.ToInt32(command.ExecuteScalar());
        sqlConnection.Close();
        return id;
        
    }
    public void InsertPerson(string fname, string lname, string userName, string password, int labId)
    {
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "INSERT into People VALUES (@lname, @fname, @username,@password, @labId)";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@lname",lname));
        command.Parameters.Add(new SqlParameter("@fname",fname));
        command.Parameters.Add(new SqlParameter("@username", userName));
        command.Parameters.Add(new SqlParameter("@password", password));
        command.Parameters.Add(new SqlParameter("@labId", labId));
        sqlConnection.Open();
        command.ExecuteNonQuery();
        sqlConnection.Close();
        
    }

    public void DeletePerson(string userName)
    {
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "Delete from people where username = @username";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@username",userName));
        sqlConnection.Open();
        command.ExecuteNonQuery();
        sqlConnection.Close();
    }

    public void UpdatePerson(string fname, string lname, string userName, string password, int labId)
    {
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "INSERT into People VALUES (@lname, @fname, @username,@password, @labId)";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@lname",lname));
        command.Parameters.Add(new SqlParameter("@fname",fname));
        command.Parameters.Add(new SqlParameter("@username", userName));
        command.Parameters.Add(new SqlParameter("@password", password));
        command.Parameters.Add(new SqlParameter("@labId", labId));
        sqlConnection.Open();
        command.ExecuteNonQuery();
        sqlConnection.Close();
    }

    public void UpdatePersonUseName(string oldUserName, string newUserName)
    {
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "UPDATE people SET username = @newUserName where username = @oldUserName";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@newUserName", newUserName));
        command.Parameters.Add(new SqlParameter("@oldUserName", oldUserName));
        sqlConnection.Open();
        command.ExecuteNonQuery();
        sqlConnection.Close();
    }

    public void UpdatePersonPassword(string oldpassword, string newpassword)
    {
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "UPDATE people SET password = @newpassword where username = @username";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@newpassword", newpassword));
        command.Parameters.Add(new SqlParameter("@username", oldpassword));
        sqlConnection.Open();
        command.ExecuteNonQuery();
        sqlConnection.Close();
    }

    public bool CheckUserName(string userName)
    {
        bool check = false;
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "SELECT * FROM people WHERE username = @userName ";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@userName", userName));
        sqlConnection.Open();
        DataTable person = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(person);
        da.Dispose();
        sqlConnection.Close();
        if (person.Rows.Count > 0)
            check = true;
        return check;
    }

    public bool CheckTheLogIn(string username, string password)
    {
        bool check = false;
        SqlConnection sqlConnection = new SqlConnection(ConnString);
        String SQLQuery = "SELECT * FROM people WHERE username = @userName and password = @password";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        command.Parameters.Add(new SqlParameter("@userName", username));
        command.Parameters.Add(new SqlParameter("@password", password));
        sqlConnection.Open();
        DataTable person = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(person);
        da.Dispose();
        sqlConnection.Close();
        if (person.Rows.Count > 0)
            check = true;
        return check;
    }

}