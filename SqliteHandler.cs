using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jpLearningToolOcr
{
    public class SqliteHandler
    {

        public string connection_string;
        public SQLiteConnection connection;

        private string stm;

        public SqliteHandler()
        {
            this.connection_string = "Data Source=language_database/jp_lang_data.db";
            this.stm = "SELECT SQLITE_VERSION()";
            this.connection = new SQLiteConnection(this.connection_string);
            this.connection.Open();

 
        }

        public void get_sqlite_version()
        {
            var cmd = new SQLiteCommand(stm, connection);
            string version = cmd.ExecuteScalar().ToString();
            Console.WriteLine(version);
        }

        public void test_query()
        {
            string test_cmd =
                "SELECT chr FROM chr";
            var cmd = new SQLiteCommand(test_cmd, connection);
            string result = cmd.ExecuteScalar().ToString();
            Console.WriteLine(result);
        }
        
    }
}
