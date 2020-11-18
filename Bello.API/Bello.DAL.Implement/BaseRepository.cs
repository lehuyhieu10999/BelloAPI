using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Bello.DAL.Implement
{
    public class BaseRepository
    {
        public  IDbConnection connection;
        public BaseRepository()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M2RQ9DH\SQLEXPRESS;Initial Catalog=BelloDb;Integrated Security=True");
        }
    }
}
