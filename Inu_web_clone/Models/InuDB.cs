using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inu_web_clone.Models
{
    public class InuDB : IDisposable
    {
        public MySqlConnection Connection { get; }
        public InuDB(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void Dispose() => Connection.Dispose();
    }
}
