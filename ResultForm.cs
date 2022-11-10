using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpLearningToolOcr
{
    public partial class ResultForm : Form
    {

        public static SearchResult query_result = new SearchResult();
        List<String> results;
        public ResultForm()
        {
            InitializeComponent();
            this.results = new List<string>();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = "";
            if (this.resultsBox.SelectedItem != null)
            {
                query_result.readings.Clear();
                this.wordReadingsBox.Items.Clear();
                query_result.meanings.Clear();
                this.wordMeaningsBox.Items.Clear();
                selection = this.resultsBox.SelectedItem.ToString();
                MainForm.handler.get_entry(selection);
                MainForm.handler.get_reading(query_result.entry_id);
                MainForm.handler.get_meanings(query_result.entry_id);
                Console.WriteLine(query_result.meanings.Count);
            }
            else
            {
                Console.WriteLine("error");
            }
            MainForm.handler.test_command(selection);

            this.selectedWordBox.Text = query_result.word;
            //this.hiraganaReading.Text = query_result.reading;
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

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void ResultForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
