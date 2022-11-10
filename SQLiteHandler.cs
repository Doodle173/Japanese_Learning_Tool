using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Web;

namespace jpLearningToolOcr
{
    public class SQLiteHandler
    {

        private string connection_string = "Data Source = language_database/jp_lang_data.db";
        private SQLiteConnection connection;

        private string sqlite_version_cmd = "SELECT SQLITE_VERSION()";
        private string sqlite_version;
        public SQLiteHandler()
        {
            this.connection = new SQLiteConnection(connection_string);
            this.connection.Open();
            
            var cmd = new SQLiteCommand(sqlite_version_cmd, connection);
            this.sqlite_version = cmd.ExecuteScalar().ToString();

            Console.WriteLine("SQLite Version: " + this.sqlite_version);

        }

    }
}
