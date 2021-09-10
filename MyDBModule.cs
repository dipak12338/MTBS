/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace regiform
{
   class DBHandler
    {

        public string CreateTable(string q)
        {
            OleDbConnection con = null;

            DBHandler obj = new DBHandler(); 
            try
            {


                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DBMetro.accdb");

                OleDbCommand cmd=new   OleDbCommand(q, con);

                con.Open();
                return "connectione stablishedd Successfully";
                cmd.ExecuteNonQuery();
                return "Quiry is successfully execute";
                
            }
            catch (Exception e)
            {

                return "OOPs, something went wrong." + e;
            }


            finally
            {
                con.Close();
            }
        }
    }
}*/