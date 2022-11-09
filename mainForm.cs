using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Common;
using System.Data.SQLite;

namespace jpLearningToolOcr
{
    public partial class mainForm : Form
    {
<<<<<<< HEAD:mainForm.cs
        public static ScreenshotTool tool = new ScreenshotTool();
        public static ResultsForm resultsForm = new ResultsForm();
        SqliteHandler handler;
=======
        ScreenshotTool tool;
        List<String> results;
        SearchTool sTool;
>>>>>>> parent of 189fbda (cleaning old code):Form1.cs

        public mainForm()
        {
            Console.OutputEncoding = Encoding.UTF8;
            InitializeComponent();
<<<<<<< HEAD:mainForm.cs
            handler = new SqliteHandler();


=======
            tool = new ScreenshotTool();
            results = new List<string>();
            this.sTool = new SearchTool();
>>>>>>> parent of 189fbda (cleaning old code):Form1.cs
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void screenshotButton_Click(object sender, EventArgs e)
        {
            tool.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD:mainForm.cs
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            foreach (String s in tool.results)
            {
                Console.WriteLine(s);
            }
        }

        private void sqliteDebugBtn_Click(object sender, EventArgs e)
        {
            handler.test_query();
        }
=======
>>>>>>> parent of 189fbda (cleaning old code):Form1.cs
    }
}
