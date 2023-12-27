using System;
using System.Data;
using System.Data.Common;

namespace FactoryDesignDB
{
    /*
        The idea here is to create a single class that handles the type of connection the client wants without writting any specifications about database.
        The ProviderFactory will basically create a database that can be used as an object.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            //We create the variables that we are gonna use, and set them all to null because we will set them on client command
            DbProviderFactory Provider = null;
            DbConnection Connection = null;
            DbCommand Command = null;
            DbDataReader DataReader = null;
            DataTable DataTable = new DataTable();


            /*if the clients wants a MySql database we just need to change "system" for "MySql" and the provider
             DBProviderFactories will do the rest*/
            Provider = DbProviderFactories.GetFactory("System.Data.SqlClient");
            Connection = Provider.CreateConnection();
            Connection.ConnectionString = "Data Source=(Local)\\You_Instance; Initial Catalog=test; Integrated Security=True;";
            Command = Provider.CreateCommand();
            try
            {
                Command.CommandText = "slect * from name";
                Command.CommandType = CommandType.Text;
                if (Connection.State == ConnectionState.Closed || Connection.State == ConnectionState.Broken)
                {
                    Connection.Open();
                    Command.Connection = Connection;
                    using (Connection)
                    {
                        DataReader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                        while(DataReader.Read())
                        {
                            Console.WriteLine(DataReader["NameTest"].ToString());
                            Console.WriteLine(DataReader["Surname"].ToString());
                        }
                    }
                }
            }catch(Exception ex)
            {
                throw;
            }
            finally
            {
                //tnr.Rollback();
                Connection.Dispose();
                Command.Dispose();
            }

        }
    }
}
