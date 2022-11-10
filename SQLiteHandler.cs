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

        private string cmd_string;
        private SQLiteCommand cmd;
        private string cmd_result;

        public SQLiteHandler()
        {
            this.connection = new SQLiteConnection(connection_string);
            this.connection.Open();
            
            this.cmd = new SQLiteCommand(sqlite_version_cmd, connection);
            this.sqlite_version = cmd.ExecuteScalar().ToString();

            Console.WriteLine("SQLite Version: " + this.sqlite_version);
        }

        public void test_command(string word)
        {
            this.cmd_string = $"SELECT entr FROM kanj WHERE txt='{word}';";
            this.cmd = new SQLiteCommand(this.cmd_string, this.connection);
            var entr = cmd.ExecuteScalar().ToString();

            this.cmd_string = $"SELECT txt FROM kanj WHERE txt='{word}';";
            this.cmd = new SQLiteCommand(this.cmd_string, this.connection);
            var search_word = cmd.ExecuteScalar().ToString();

            this.cmd_string = $"SELECT txt FROM rdng WHERE entr = '{entr}'";
            this.cmd = new SQLiteCommand(this.cmd_string, this.connection);
            var reading = cmd.ExecuteScalar().ToString();

            ResultForm.query_result.entry_id = entr;
            ResultForm.query_result.word = search_word;
            ResultForm.query_result.reading = reading;

            Console.WriteLine(reading);
            

        }

    }
}
