using System;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Ado.net
{
    class Program
    {

        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query  


                SqlCommand cm = new SqlCommand("Select * from student", con);
                // Opening Connection  
                con.Open();


                SqlDataReader sdr = cm.ExecuteReader();
                while(sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record 
                }





            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}

    


       
    


