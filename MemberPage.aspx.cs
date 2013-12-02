using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //if (Session != null)
        //{
        //    try
        //    {
                ServiceLayerPerson sv = new ServiceLayerPerson();
               // string username = Session["UserName"].ToString();
                //int id = sv.FindIdByUsername(username);

               // Session["ObjectParameterName"] = id;

                GridView1.DataSource = sv.FindPersonById(17);
                GridView1.DataBind();


        //    }catch
        //    {
        //        Response.Redirect("Login.aspx");
        //    }
        //} 
        
    
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string newUserName = TextBox1.Text;
        string newPassword = TextBox2.Text;
        string username = Session["UserName"].ToString();

        ServiceLayerPerson sv = new ServiceLayerPerson();
        if (newUserName != "")
        {
            sv.UpdatePersonUseName(username, newUserName);
            TextBox3.Text = "Your new userName is " + newUserName;
        }
        if (newPassword != "")
        {

            sv.UpdatePersonPassword(username, newPassword);
            TextBox3.Text = "Your new Password is " + newPassword;
        }
        if (newPassword != "" && newUserName != "")
        {
            sv.UpdatePersonPassword(username, newPassword);
            sv.UpdatePersonUseName(username, newUserName);
            TextBox3.Text = @"UserName is " + newUserName + " and password is " + newPassword;
        }
    }
}