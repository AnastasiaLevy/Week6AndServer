using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {   
        int labId = int.Parse(DropDownList1.SelectedValue);
        ServiceLayerPerson person = new ServiceLayerPerson();
        string username = Session["UserName"].ToString();
        string password = Session["Password"].ToString();
        person.InsertPerson(TextBox1.Text, TextBox2.Text,username, password, labId);

        Button1.Text = "Profile update";
    }
} 