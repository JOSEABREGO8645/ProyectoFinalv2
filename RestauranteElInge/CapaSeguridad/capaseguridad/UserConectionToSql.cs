﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaSeguridad
{
    
        public abstract class UserConnectionToSql
        {
            private readonly string connectionString;
            public UserConnectionToSql()
            {
                connectionString = "Data Source=HP-VICTUS-16\\SQLEXPRESS;Initial Catalog=db_Restaurante_El_Inge;Integrated Security=True";
            }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }

        }
    
}
