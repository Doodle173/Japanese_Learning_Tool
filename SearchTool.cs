using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace jpLearningToolOcr
{
    class SearchTool
    {

        WebClient client;
        
        public SearchTool()
        {
            this.client = new WebClient();
        }

        //public SearchResult search(string searchValue)
        //{
        //    Stream stream = client.OpenRead($"https://jisho.org/api/v1/search/words?keyword={searchValue}");
        //    StreamReader reader = new StreamReader(stream);
        //    string json = reader.ReadToEnd();
        //    stream.Close();
        //    reader.Close();

        //    JObject o = JObject.Parse(json);

        //    SearchResult result = new SearchResult();

        //    result.word = (string)o.SelectToken("$.data[0].japanese[0].word");
        //    result.reading = (string)o.SelectToken("$.data[0].japanese[0].reading");
        //    result.meanings = o.SelectToken("$.data[0].senses[0].english_definitions");
        //    result.partOfSpeech = o.SelectToken("$.data[0].senses[0].parts_of_speech");
        //    result.jlpt = (string)o.SelectToken("$.data[0].jlpt[0]");

        //    return result;
        //}

        public SearchResult search(string searchValue)
        {
        }





    }
}
