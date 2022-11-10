
namespace jpLearningToolOcr
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.selectedWordBox = new System.Windows.Forms.TextBox();
            this.scannedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scanAccuracy = new System.Windows.Forms.TextBox();
            this.hiraganaReadingLabel = new System.Windows.Forms.Label();
            this.hiraganaReading = new System.Windows.Forms.TextBox();
            this.wordMeaningsBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wordReadingsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // resultsBox
            // 
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.Location = new System.Drawing.Point(12, 23);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(223, 329);
            this.resultsBox.TabIndex = 0;
            this.resultsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // selectedWordBox
            // 
            this.selectedWordBox.HideSelection = false;
            this.selectedWordBox.Location = new System.Drawing.Point(241, 23);
            this.selectedWordBox.Name = "selectedWordBox";
            this.selectedWordBox.ReadOnly = true;
            this.selectedWordBox.Size = new System.Drawing.Size(100, 20);
            this.selectedWordBox.TabIndex = 1;
            this.selectedWordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // scannedText
            // 
            this.scannedText.HideSelection = false;
            this.scannedText.Location = new System.Drawing.Point(15, 390);
            this.scannedText.Multiline = true;
            this.scannedText.Name = "scannedText";
            this.scannedText.ReadOnly = true;
            this.scannedText.Size = new System.Drawing.Size(223, 94);
            this.scannedText.TabIndex = 2;
            this.scannedText.TextChanged += new System.EventHandler(this.scannedText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scanned Individual Words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scanned Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currently Selected Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scan Accuracy";
            // 
            // scanAccuracy
            // 
            this.scanAccuracy.HideSelection = false;
            this.scanAccuracy.Location = new System.Drawing.Point(369, 23);
            this.scanAccuracy.Name = "scanAccuracy";
            this.scanAccuracy.ReadOnly = true;
            this.scanAccuracy.Size = new System.Drawing.Size(100, 20);
            this.scanAccuracy.TabIndex = 7;
            this.scanAccuracy.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hiraganaReadingLabel
            // 
            this.hiraganaReadingLabel.AutoSize = true;
            this.hiraganaReadingLabel.Location = new System.Drawing.Point(241, 46);
            this.hiraganaReadingLabel.Name = "hiraganaReadingLabel";
            this.hiraganaReadingLabel.Size = new System.Drawing.Size(96, 13);
            this.hiraganaReadingLabel.TabIndex = 8;
            this.hiraganaReadingLabel.Text = "Hiragana Reading:";
            this.hiraganaReadingLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // hiraganaReading
            // 
            this.hiraganaReading.HideSelection = false;
            this.hiraganaReading.Location = new System.Drawing.Point(241, 62);
            this.hiraganaReading.Name = "hiraganaReading";
            this.hiraganaReading.ReadOnly = true;
            this.hiraganaReading.Size = new System.Drawing.Size(100, 20);
            this.hiraganaReading.TabIndex = 9;
            this.hiraganaReading.TextChanged += new System.EventHandler(this.hiraganaReading_TextChanged);
            // 
            // wordMeaningsBox
            // 
            this.wordMeaningsBox.FormattingEnabled = true;
            this.wordMeaningsBox.Location = new System.Drawing.Point(369, 101);
            this.wordMeaningsBox.Name = "wordMeaningsBox";
            this.wordMeaningsBox.Size = new System.Drawing.Size(165, 251);
            this.wordMeaningsBox.TabIndex = 10;
            this.wordMeaningsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Word Meanings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Word Readings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "JLPT:";
            // 
            // textBox1
            // 
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(369, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // wordReadingsBox
            // 
            this.wordReadingsBox.FormattingEnabled = true;
            this.wordReadingsBox.Location = new System.Drawing.Point(241, 101);
            this.wordReadingsBox.Name = "wordReadingsBox";
            this.wordReadingsBox.Size = new System.Drawing.Size(119, 251);
            this.wordReadingsBox.TabIndex = 16;
            this.wordReadingsBox.SelectedIndexChanged += new System.EventHandler(this.pos_box_SelectedIndexChanged);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 496);
            this.Controls.Add(this.wordReadingsBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wordMeaningsBox);
            this.Controls.Add(this.hiraganaReading);
            this.Controls.Add(this.hiraganaReadingLabel);
            this.Controls.Add(this.scanAccuracy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scannedText);
            this.Controls.Add(this.selectedWordBox);
            this.Controls.Add(this.resultsBox);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultsBox;
        private System.Windows.Forms.TextBox selectedWordBox;
        private System.Windows.Forms.TextBox scannedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scanAccuracy;
        private System.Windows.Forms.Label hiraganaReadingLabel;
        private System.Windows.Forms.TextBox hiraganaReading;
        private System.Windows.Forms.ListBox wordMeaningsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox wordReadingsBox;
    }
}