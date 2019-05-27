using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Krryp.Data { 

    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
