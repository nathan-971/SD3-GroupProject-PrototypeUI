using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Forms_Prototype
{
    public abstract class DatabaseConnection : IDisposable
    {
        protected string _server;
        protected string _username;
        protected string _password;
        protected string _database;
        public abstract bool query(string query);
        public abstract Dictionary<string, string> requestDescription(string table);
        public abstract DataTable requestAllRecords(string table);
        public abstract string[] requestAllTables();
        public abstract void Dispose();
    }
}
