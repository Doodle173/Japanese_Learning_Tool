using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpLearningToolOcr
{
    public partial class ResultForm : Form
    {
        List<String> results;
        SearchTool searchTool;
        public ResultForm()
        {
            InitializeComponent();
            this.results = new List<string>();
            this.searchTool = new SearchTool();
            
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.wordMeaningsBox.Items.Clear();
            this.pos_box.Items.Clear();
            SearchResult result;

            string selectedVal = this.resultsBox.SelectedItem.ToString();

            this.selectedWordBox.Text = selectedVal;
            result = this.searchTool.search(selectedVal);

            hiraganaReading.Text = result.reading;

            textBox1.Text = result.jlpt;

            if (result.meanings == null)
            {
                this.wordMeaningsBox.Items.Clear();
            }
            else
            {
                foreach (Newtonsoft.Json.Linq.JToken token in result.meanings)
                {
                    this.wordMeaningsBox.Items.Add(token.ToString());
                }
                foreach (Newtonsoft.Json.Linq.JToken token in result.partOfSpeech)
                {
                    this.pos_box.Items.Add(token.ToString());
                }
            }

        }

        public void setResults(List<String> values)
        {
            this.resultsBox.Items.Clear();

            foreach(string s in values)
            {
                this.resultsBox.Items.Add(s);
            }
        }

        public void setScannedText(String value)
        {
            this.scannedText.Text = value;
        }

        public void setScanAccuracy(String value)
        {
            this.scanAccuracy.Text = value + "%";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void scannedText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scannedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hiraganaReading_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pos_result_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pos_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
