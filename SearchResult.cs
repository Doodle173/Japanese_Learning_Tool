using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace jpLearningToolOcr
{
    class SearchResult
    {

        public string word { get; set; }
        public string reading { get; set; }
        
        public JToken partOfSpeech { get; set; }

        public string jlpt { get; set; }

        public JToken meanings { get; set; } 



        
        public SearchResult()
        {

        }

        public SearchResult(string word)
        {
            this.word = word;
        }
        
    }
}
