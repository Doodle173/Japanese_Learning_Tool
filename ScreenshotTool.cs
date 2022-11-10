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
    //Main sources I used to learn how to do this:
    //http://forum.codecall.net/topic/78186-c-tutorial-drawing-rectangles-with-the-mouse/
    //https://michaelscodingspot.com/find-fix-and-avoid-memory-leaks-in-c-net-8-best-practices/ 
    //https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-capture-a-screen-using-C-Sharp/

    public partial class ScreenshotTool : Form
    {
        private Graphics bitmapGenerator;
        private Bitmap selectionScreenshot;

        MessageBoxButtons confirmationButtons = MessageBoxButtons.YesNo;
        DialogResult confirmationResult;

        private int startX, startY;
        private bool isDrawing;

        private Rectangle selectionRectangle;

        TesseractOcr ocrObject;

        public List<string> results;

        ResultForm resultForm;
        
        public ScreenshotTool()
        {
            InitializeComponent();
            beginSnipping();
            this.results = new List<string>();
            this.resultForm = new ResultForm();
            
        }

        private void beginSnipping()
        {

            this.WindowState = FormWindowState.Maximized;
            this.Opacity = 0.35f;
            this.FormBorderStyle = FormBorderStyle.None;

            this.MouseDown += form_MouseDown;
            this.MouseUp += form_MouseUp;
            this.MouseMove += form_onMouseMove;

            this.KeyDown += form_keyDown;

            this.Paint += selectionForm_OnPaint;

            this.DoubleBuffered = true;

            this.ShowInTaskbar = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private  bool confirmResults()
        {
            confirmationResult = MessageBox.Show("Pressing no will return you to selection mode.", "Would you like to use this selection?", confirmationButtons);
            if (confirmationResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide(); //Hide the UI used for taking screenshots
                this.resultForm.Show();
                selectionScreenshot = new Bitmap(selectionRectangle.Width, selectionRectangle.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                bitmapGenerator = Graphics.FromImage(selectionScreenshot);
                bitmapGenerator.CopyFromScreen(selectionRectangle.Left, selectionRectangle.Top, 0, 0, selectionRectangle.Size);
                selectionScreenshot.Save(@"output.png", System.Drawing.Imaging.ImageFormat.Png);

                ocrObject = new TesseractOcr();

                string result = "";
                result = ocrObject.getTokenizedResults(selectionScreenshot); //Use mecab to tokenize the text that was scanned
                Console.WriteLine(result);
                

                this.results = this.ocrObject.getParsedWordsList();

                Console.WriteLine(results.Count);
                this.resultForm.setResults(this.results);
                this.resultForm.setScannedText(ocrObject.getResult());
                this.resultForm.setScanAccuracy(ocrObject.getAccuracy().ToString());
                return true;
            }
            return false;
        }

        public List<String> getResultsList()
        {
            return this.results;
        }

        public void showForm()
        {
            this.resultForm.Hide();
            this.Show();
        }

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            this.isDrawing = true;
            this.startX = e.X;
            this.startY = e.Y;
        }
        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDrawing = false;
            Console.WriteLine("Selection bounds: " + selectionRectangle);
            this.confirmResults();
        }

        private void form_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainForm.ActiveForm.Hide();
            }
        }
        private void form_onMouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing)
            {
                return;
            }

            int x = Math.Min(startX, e.X);
            int y = Math.Min(startY, e.Y);

            int width = Math.Max(startX, e.X) - Math.Min(startX, e.X);
            int height = Math.Max(startY, e.Y) - Math.Min(startY, e.Y);

            this.selectionRectangle.Width = width;
            this.selectionRectangle.Height = height;
            this.selectionRectangle.X = x;
            this.selectionRectangle.Y = y;

            this.Refresh();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ScreenshotTool
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ScreenshotTool";
            this.Load += new System.EventHandler(this.ScreenshotTool_Load);
            this.ResumeLayout(false);

        }

        private void ScreenshotTool_Load(object sender, EventArgs e)
        {

        }

        private void selectionForm_OnPaint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                e.Graphics.DrawRectangle(pen, this.selectionRectangle);
            }
        }
    }
}
