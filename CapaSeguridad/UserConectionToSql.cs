using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSeguridad
{
    
        public abstract class UserConnectionToSql
        {
            private readonly string connectionString;
            public UserConnectionToSql()
            {
                connectionString = "Data Source=HP-VICTUS-16\\SQLEXPRESS;Initial Catalog=db_MenuLogin;Integrated Security=True";
            }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }

        }
    
}
