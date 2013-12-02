using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        string fName = firstName.Text;
        string lname = lastName.Text;
        string userName = UserName.Text;
        string password = Password.Text;
        if (password != Cpassword.Text)
        {
            Password.Focus();
        }
        int labId = int.Parse(LabList.SelectedValue);
        //Membership.CreateUser(userName, password);
        Response.Redirect("LogIn.aspx");
       
        ServiceLayerPerson person = new ServiceLayerPerson();
        person.InsertPerson(fName, lname, userName, password, labId);
            
       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}