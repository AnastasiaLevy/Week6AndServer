using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AuthenticateFromDB
/// </summary>
public class AuthenticateFromDB
{
    string ConnString = ConfigurationManager.ConnectionStrings["ClassProjectDataBaseEntities"].ConnectionString;
	public AuthenticateFromDB()
	{
		//
		// TODO: Add constructor logic here
		//
	}

   
}