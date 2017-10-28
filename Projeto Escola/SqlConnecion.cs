using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Amazon;
using System.Data.Sql;


namespace Projeto_Escola
{
    public class SqlConnecions
    {

        internal static SqlConnection CreateConnection()
        {
            string connectionstring = null;

            connectionstring = @"Data Source=sisedudbmssql.c81rglw9ovnp.sa-east-1.rds.amazonaws.com;Initial Catalog=sisedudb;User ID=jkssisedu;Password=jkscorporationsisedu";


            SqlConnection connection;

            connection = new SqlConnection(connectionstring);

            
                         
                return connection;
            
        } 
          
        
    
    }
}
