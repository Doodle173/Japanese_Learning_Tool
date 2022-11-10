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
namespace jpLearningToolOcr
{
    public partial class MainForm : Form
    {
        public static ScreenshotTool tool = new ScreenshotTool();
        public static SQLiteHandler handler;
        public static List<String> results = new List<string>();
        
        public MainForm()
        {
            Console.OutputEncoding = Encoding.UTF8;
            InitializeComponent();
            handler = new SQLiteHandler();
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

    }
}
