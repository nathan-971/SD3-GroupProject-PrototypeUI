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
        public abstract bool query(string query);
        public abstract Dictionary<string, string> requestDescription(string table);
        public abstract DataTable requestAllRecords(string table);
        public abstract void Dispose();
    }
}
