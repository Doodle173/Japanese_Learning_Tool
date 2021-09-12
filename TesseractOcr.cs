using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
using Tesseract;
using System.Globalization;
using MeCab;

namespace jpLearningToolOcr
{
    class TesseractOcr
    {

        List<String> parsedWords;
        string ocrResult;
        float accuracy;
        public TesseractOcr()
        {
            this.parsedWords = new List<string>();
        }

        private string useOcr(Bitmap someImage)
        {
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "jpn", EngineMode.Default))
                {

                    using (var image = someImage)
                    {
                        using (var page = engine.Process(image))
                        {
                            string result = page.GetText();
                            Console.WriteLine("Tesseract OCR Results:\n");

                            Console.WriteLine("Scan accuracy: " + page.GetMeanConfidence() + "%");
                            this.accuracy = page.GetMeanConfidence();
                            Console.WriteLine(result);
                            return result;
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            return "";
        }

        public List<string> getParsedWordsList()
        {
            return this.parsedWords;
        }
        public string getResult()
        {
            return this.ocrResult;
        }

        public float getAccuracy()
        {
            return this.accuracy * 100;
        }
        public string getTokenizedResults(Bitmap bitmap)
        {
            this.ocrResult = useOcr(bitmap);

            var txt = ocrResult;
            var param = new MeCabParam();
            MeCabTagger tagger = MeCabTagger.Create();

            Console.WriteLine("Mecab Results:");

            txt = txt.Replace(" ", String.Empty);
            Console.WriteLine(txt);


            

            foreach (var node in tagger.ParseToNodes(txt))
            {
                if (node.CharType > 0)
                {
                    var features = node.Feature.Split(',');
                    var displayFeatures = string.Join(", ", features);

                    //Console.WriteLine($"{node.Surface}\t{displayFeatures}");
                    Console.WriteLine($"{node.Surface}");
                    parsedWords.Add(node.Surface);
                }
            }

            return "";
        }
        
    }
    

}
