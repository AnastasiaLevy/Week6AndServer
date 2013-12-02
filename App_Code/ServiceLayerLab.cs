using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for ServiceLayerLab
/// </summary>
public class ServiceLayerLab
{
    string connString = ConfigurationManager.ConnectionStrings["ClassProjectDataBaseEntities"].ConnectionString;
	public ServiceLayerLab()
	{
	}
    public DataTable ReturnListOfLabs()
    {
        SqlConnection sqlConnection = new SqlConnection(connString);
        String SQLQuery = "SELECT * FROM Labs";
        SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
        sqlConnection.Open();
        DataTable fullSet = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(fullSet);
        da.Dispose();
        sqlConnection.Close();
        return fullSet;
    }
}