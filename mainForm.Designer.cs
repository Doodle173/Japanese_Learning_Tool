
namespace jpLearningToolOcr
{
    partial class mainForm
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
            this.screenshotButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
<<<<<<< HEAD:mainForm.Designer.cs
            this.debugButton = new System.Windows.Forms.Button();
            this.sqliteDebugBtn = new System.Windows.Forms.Button();
=======
>>>>>>> parent of 189fbda (cleaning old code):Form1.Designer.cs
            this.SuspendLayout();
            // 
            // screenshotButton
            // 
            this.screenshotButton.Location = new System.Drawing.Point(12, 12);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(300, 99);
            this.screenshotButton.TabIndex = 0;
            this.screenshotButton.Text = "Take Screenshot";
            this.screenshotButton.UseVisualStyleBackColor = true;
            this.screenshotButton.Click += new System.EventHandler(this.screenshotButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 60);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "NOTE: To close the selection screen / mode, press ESCAPE. This will remove the se" +
    "lection tool.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
<<<<<<< HEAD:mainForm.Designer.cs
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(263, 154);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 23);
            this.debugButton.TabIndex = 2;
            this.debugButton.Text = "debug_btn";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // sqliteDebugBtn
            // 
            this.sqliteDebugBtn.Location = new System.Drawing.Point(182, 154);
            this.sqliteDebugBtn.Name = "sqliteDebugBtn";
            this.sqliteDebugBtn.Size = new System.Drawing.Size(75, 23);
            this.sqliteDebugBtn.TabIndex = 3;
            this.sqliteDebugBtn.Text = "debug_sqlite";
            this.sqliteDebugBtn.UseVisualStyleBackColor = true;
            this.sqliteDebugBtn.Click += new System.EventHandler(this.sqliteDebugBtn_Click);
            // 
=======
>>>>>>> parent of 189fbda (cleaning old code):Form1.Designer.cs
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD:mainForm.Designer.cs
            this.ClientSize = new System.Drawing.Size(350, 187);
            this.Controls.Add(this.sqliteDebugBtn);
            this.Controls.Add(this.debugButton);
=======
            this.ClientSize = new System.Drawing.Size(323, 157);
>>>>>>> parent of 189fbda (cleaning old code):Form1.Designer.cs
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.screenshotButton);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.TextBox textBox1;
<<<<<<< HEAD:mainForm.Designer.cs
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button sqliteDebugBtn;
=======
>>>>>>> parent of 189fbda (cleaning old code):Form1.Designer.cs
    }
}

