namespace EmailToText
{
    partial class recordForm
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
            this.clearButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.recordShowRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveRecordFormButton = new System.Windows.Forms.Button();
            this.loadRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(192, 312);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // recordShowRichTextBox
            // 
            this.recordShowRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.recordShowRichTextBox.Name = "recordShowRichTextBox";
            this.recordShowRichTextBox.Size = new System.Drawing.Size(348, 274);
            this.recordShowRichTextBox.TabIndex = 3;
            this.recordShowRichTextBox.Text = "";
            this.recordShowRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // saveRecordFormButton
            // 
            this.saveRecordFormButton.Location = new System.Drawing.Point(12, 312);
            this.saveRecordFormButton.Name = "saveRecordFormButton";
            this.saveRecordFormButton.Size = new System.Drawing.Size(75, 23);
            this.saveRecordFormButton.TabIndex = 4;
            this.saveRecordFormButton.Text = "New record";
            this.saveRecordFormButton.UseVisualStyleBackColor = true;
            this.saveRecordFormButton.Click += new System.EventHandler(this.saveRecordFormButton_Click);
            // 
            // loadRecordButton
            // 
            this.loadRecordButton.Location = new System.Drawing.Point(102, 312);
            this.loadRecordButton.Name = "loadRecordButton";
            this.loadRecordButton.Size = new System.Drawing.Size(75, 23);
            this.loadRecordButton.TabIndex = 5;
            this.loadRecordButton.Text = "Load";
            this.loadRecordButton.UseVisualStyleBackColor = true;
            this.loadRecordButton.Click += new System.EventHandler(this.loadRecordButton_Click);
            // 
            // recordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 380);
            this.Controls.Add(this.loadRecordButton);
            this.Controls.Add(this.saveRecordFormButton);
            this.Controls.Add(this.recordShowRichTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clearButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recordForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox recordShowRichTextBox;
        private System.Windows.Forms.Button saveRecordFormButton;
        private System.Windows.Forms.Button loadRecordButton;
    }
}