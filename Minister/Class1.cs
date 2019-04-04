using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
   public  class Connect
    {  
       public SqlConnection con;
       public  SqlCommand cd;
       public SqlDataReader dr;
       public SqlDataAdapter ad;
       
        public void getconn()     // opening the connection to database .
       {
           con = new SqlConnection(@"Data Source=sree-PC;Initial Catalog=Office;User ID=sa;Password=s");
           con.Open(); 
       }

        public void save(string x)      // insert, delete,update queries

        {
            cd = new SqlCommand(x, con);
            
            
            cd.ExecuteNonQuery();
        }  
           
       public void exe(string x)
        {
            cd = new SqlCommand(x, con);
       }

       public void readata(string x)      // reading data from database.
       {  
           cd = new SqlCommand(x, con);
           dr = cd.ExecuteReader();
       }

       public void closeread()
       {
           dr.Close();
       }

       public void closed1()
       {
           con.Close();
       }
       


       //public void adapter(string x)
       //{
       //    ad = new SqlDataAdapter();
       //    ds = new datas
       //}
    }
}
