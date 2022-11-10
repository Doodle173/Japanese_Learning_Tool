using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpLearningToolOcr
{
    public class SearchResult
    {

        public string entry_id;
        public string word;
        public List<string> readings;
        public List<string> meanings;
        public SearchResult()
        {
            this.readings = new List<string>();
            this.meanings = new List<string>();
        }

    }
}
