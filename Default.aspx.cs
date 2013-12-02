using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session != null)
        {
            try
            {
                ServiceLayerPerson sv = new ServiceLayerPerson();
                string username = Session["UserName"].ToString();
                int id = sv.FindIdByUsername(username);

                Session["ObjectParameterName"] = id;

                GridView2.DataSource = sv.FindPersonById(id);
                GridView2.DataBind();
                


            }
            catch
            {
                //Response.Redirect("Login.aspx");
            }
        }


    }


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Session["role"].ToString();
    }
}