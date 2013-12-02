using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for BusinessLayer
/// </summary>
public class BusinessLayer
{
	public BusinessLayer()
	{
	}

    public List<DAL.Lab> ReturnList()
    {
        DAL.Lab labClass = new DAL.Lab();
        ServiceLayerLab labs = new ServiceLayerLab();
        DataTable dt = labs.ReturnListOfLabs();
        List<DAL.Lab> list = dt.AsEnumerable().Select(r => new DAL.Lab()
           {
               Id = (int)r["Id"],
               Schedule = (string)r["Schedule"]
           }
            ).ToList();

        ;
        return list;
    }

}