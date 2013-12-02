using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using System.Linq;

namespace ClientServerExample
{
    public class server
    {
        public static void Main()
        {
            try
            {
                System.Threading.Thread workerThread =
                    new System.Threading.Thread(NewConnection);
                workerThread.Start();
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
            Console.ReadLine();
            
        }

        private static void NewConnection()
        {
            string myIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).Select(ip => ip.ToString()).FirstOrDefault() ?? "";
            IPAddress ipAd = IPAddress.Parse(myIp);

            TcpListener myList = new TcpListener(ipAd, 8001);

            myList.Start();

            Console.WriteLine("The server is running at port 8001...");
            Console.WriteLine("The local End point is  :" +
                              myList.LocalEndpoint);
            Console.WriteLine("Waiting for a connection.....");


            Socket s = myList.AcceptSocket();

            // 1> Get Authorization params
            // 2> Call Authenticate
            byte[] auth = new byte[100];
            int a = s.Receive(auth);
            char[] array = new char[a];
            Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
            for (int x = 0; x < a; x++)
            {
                array[x] = Convert.ToChar(auth[x]);

            }
            string usernamePassword = new string(array);
            string[] results = usernamePassword.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string userName = results[0];
            string passWord = results[1];
            Console.WriteLine(userName);
            Console.WriteLine(passWord);
            string reply = "false";

            //if (!Membership.ValidateUser(userName, passWord))
            if (CheckTheLogIn(userName, passWord))
            {
                Console.WriteLine("authorised");
                reply = "true";

            }

            ASCIIEncoding asen = new ASCIIEncoding();
            s.Send(asen.GetBytes(reply));

            /* clean up */
            s.Close();
            myList.Stop();
        }
        public static bool CheckTheLogIn(string username, string password)
        {
            bool check = false;
            string connString = ConfigurationManager.ConnectionStrings["ClassProjectDataBaseEntities"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connString);
            String SQLQuery = "SELECT * FROM people WHERE username = @userName and password = @password";
            SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
            command.Parameters.Add(new SqlParameter("@userName", username));
            command.Parameters.Add(new SqlParameter("@password", password));
            sqlConnection.Open();
            DataTable person = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(person);
            da.Dispose();
            sqlConnection.Close();
            if (person.Rows.Count > 0)
                check = true;
            return check;
        }

    }

}
