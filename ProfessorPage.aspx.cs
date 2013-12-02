using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string examName = ExamName.Text;
        DateTime examTime = Convert.ToDateTime(TextBox2.Text);
        ServiceLayerEvent sv = new ServiceLayerEvent();
        sv.CreateEvent(examName, examTime);
        //GridView1.DataSource = sv.ReturnFullList();
        GridView3.DataBind();
        ExamName.Text = "";
        TextBox2.Text = "";




    }
}