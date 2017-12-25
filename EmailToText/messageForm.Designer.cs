namespace EmailToText
{
    partial class messageForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.carrierLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.cboCarrier = new System.Windows.Forms.ComboBox();
            this.sendTextbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mailServerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailAccountComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailToPhoneTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.listRecords = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Carrier Lookup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(516, 686);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "&Exit ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(23, 438);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(376, 20);
            this.subjectTextBox.TabIndex = 4;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(23, 504);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(478, 202);
            this.messageTextBox.TabIndex = 5;
            this.messageTextBox.Text = "";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(20, 411);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(43, 13);
            this.subjectLabel.TabIndex = 6;
            this.subjectLabel.Text = "Subject";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(20, 475);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.MessageLabel.TabIndex = 7;
            this.MessageLabel.Text = "Message";
            // 
            // carrierLabel
            // 
            this.carrierLabel.AutoSize = true;
            this.carrierLabel.Location = new System.Drawing.Point(3, 15);
            this.carrierLabel.Name = "carrierLabel";
            this.carrierLabel.Size = new System.Drawing.Size(81, 13);
            this.carrierLabel.TabIndex = 8;
            this.carrierLabel.Text = "Email Extension";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(20, 283);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(118, 13);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "Phone Number or Email";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(23, 308);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(273, 20);
            this.phoneNumberTextBox.TabIndex = 11;
            // 
            // cboCarrier
            // 
            this.cboCarrier.FormattingEnabled = true;
            this.cboCarrier.Location = new System.Drawing.Point(23, 367);
            this.cboCarrier.Name = "cboCarrier";
            this.cboCarrier.Size = new System.Drawing.Size(273, 21);
            this.cboCarrier.TabIndex = 12;
            this.cboCarrier.SelectedIndexChanged += new System.EventHandler(this.cboCarrier_SelectedIndexChanged);
            // 
            // sendTextbutton
            // 
            this.sendTextbutton.Location = new System.Drawing.Point(516, 482);
            this.sendTextbutton.Name = "sendTextbutton";
            this.sendTextbutton.Size = new System.Drawing.Size(111, 23);
            this.sendTextbutton.TabIndex = 13;
            this.sendTextbutton.Text = "&Send";
            this.sendTextbutton.UseVisualStyleBackColor = true;
            this.sendTextbutton.Click += new System.EventHandler(this.sendTextbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phone Carrier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mail Server";
            // 
            // mailServerTextBox
            // 
            this.mailServerTextBox.Location = new System.Drawing.Point(6, 106);
            this.mailServerTextBox.Name = "mailServerTextBox";
            this.mailServerTextBox.ReadOnly = true;
            this.mailServerTextBox.Size = new System.Drawing.Size(207, 20);
            this.mailServerTextBox.TabIndex = 18;
            this.mailServerTextBox.TextChanged += new System.EventHandler(this.mailServerTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(8, 57);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(183, 20);
            this.usernameTextBox.TabIndex = 21;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(8, 123);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(183, 20);
            this.passwordTextBox.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.emailAccountComboBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(23, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 230);
            this.panel1.TabIndex = 23;
            // 
            // emailAccountComboBox
            // 
            this.emailAccountComboBox.FormattingEnabled = true;
            this.emailAccountComboBox.Items.AddRange(new object[] {
            "Hotmail",
            "Yahoo",
            "Gmail"});
            this.emailAccountComboBox.Location = new System.Drawing.Point(8, 186);
            this.emailAccountComboBox.Name = "emailAccountComboBox";
            this.emailAccountComboBox.Size = new System.Drawing.Size(175, 21);
            this.emailAccountComboBox.TabIndex = 27;
            this.emailAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.emailAccountComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email Account Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email Login";
            // 
            // emailToPhoneTextBox
            // 
            this.emailToPhoneTextBox.Location = new System.Drawing.Point(6, 40);
            this.emailToPhoneTextBox.Name = "emailToPhoneTextBox";
            this.emailToPhoneTextBox.ReadOnly = true;
            this.emailToPhoneTextBox.Size = new System.Drawing.Size(207, 20);
            this.emailToPhoneTextBox.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.carrierLabel);
            this.panel2.Controls.Add(this.emailToPhoneTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mailServerTextBox);
            this.panel2.Location = new System.Drawing.Point(336, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 146);
            this.panel2.TabIndex = 26;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(516, 634);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 23);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // listRecords
            // 
            this.listRecords.Location = new System.Drawing.Point(516, 531);
            this.listRecords.Name = "listRecords";
            this.listRecords.Size = new System.Drawing.Size(111, 23);
            this.listRecords.TabIndex = 28;
            this.listRecords.Text = "&Phone Number List";
            this.listRecords.UseVisualStyleBackColor = true;
            this.listRecords.Click += new System.EventHandler(this.listRecords_Click);
            // 
            // messageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 718);
            this.Controls.Add(this.listRecords);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendTextbutton);
            this.Controls.Add(this.cboCarrier);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.Name = "messageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.messageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label carrierLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ComboBox cboCarrier;
        private System.Windows.Forms.Button sendTextbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailServerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailToPhoneTextBox;
        private System.Windows.Forms.ComboBox emailAccountComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button listRecords;
    }
}