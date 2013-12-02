using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string username = Login1.UserName;
        string password = Login1.Password;
        ServiceLayerPerson sv = new ServiceLayerPerson();
        if (sv.CheckTheLogIn(username, password))
        {
            if (username == "Doctor" && password == "James")
            {
                Response.Redirect("ProfessorPage.aspx");
            }
           
            Session["UserName"] = username;
            Response.Redirect("MemberPage.aspx");
        }
        else
            TextBox1.Text = "Unable to Login. Please make sure Caps is turned of";


    }
}