using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ASPlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
    {
        //if (Membership.ValidateUser(Login1.UserName, Login1.Password))
        //{
        //    Session["UserName"] = Login1.UserName;
        //    Session["Password"] = Login1.Password;
        //    e.Authenticated = true;
        //    if (Roles.IsUserInRole("student"))
        //    {
        //        Login1.DestinationPageUrl = "FlexBox.aspx";
        //        Session["role"] = "student";
        //    }

        //    else if (Roles.IsUserInRole("proff"))
        //        Login1.DestinationPageUrl = "Default.aspx";
       // }
        string username = Login1.UserName;
        string password = Login1.Password;
        string toSend = username + "/" + password;
        try
        {
            TcpClient tcpClient = new TcpClient();
            Console.WriteLine("Connecting.....");
            ASCIIEncoding asen = new ASCIIEncoding();
            string myIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).Select(ip => ip.ToString()).FirstOrDefault() ?? "";
            tcpClient.Connect(myIp, 8001);

             
            Stream stm = tcpClient.GetStream();
            

            byte[] auth = asen.GetBytes(toSend);
            stm.Write(auth, 0, auth.Length);
       
            byte[] answer = new byte[100];
            int a = stm.Read(answer, 0, 100);
            char[] array = new char[a];
           
            for (int x = 0; x < a; x++)
            {
                array[x] = Convert.ToChar(answer[x]);

            }
            string reply = new string(array);
            TextBox1.Text = reply;
            if (reply == "true")
            {
                Session["UserName"] = Login1.UserName;
                Session["Password"] = Login1.Password;
                e.Authenticated = true;
                Login1.DestinationPageUrl = "FlexBox.aspx";
               // Response.Redirect("FlexBox.aspx");
                Session["role"] = "student";
                

            }
            tcpClient.Close();
           
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error..... " + ex.StackTrace);
        }
    }
   



}




