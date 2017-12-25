using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EmailToText
{
    public partial class recordForm : Form
    {
        public recordForm()
        {
            InitializeComponent();

            using (StreamReader reader = File.OpenText("PhoneNumbers.txt"))
            {
                for (var i = 0; i < 500; i++)
                    recordShowRichTextBox.Text += reader.ReadLine() + "\r\n";
                reader.Close();
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Clear all phone records?", "Warning",
MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               //recordShowRichTextBox.Clear();

                StreamWriter strm = File.CreateText("PhoneNumbers.txt");
                strm.Flush();
                strm.Close();
                recordShowRichTextBox.Clear();


            }
            else if (result == DialogResult.No)
            {
                //Do nothing
            }



          /*  else if (result == DialogResult.Cancel)
            {
                //code for Cancel
            }*/
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void saveRecordFormButton_Click(object sender, EventArgs e)
        {
            saveRecordForm saveRecordForm = new saveRecordForm();
            saveRecordForm.Show();
        }

        private void loadRecordButton_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = File.OpenText("PhoneNumbers.txt"))
            {
                for (var i = 0; i < 500; i++)
                    recordShowRichTextBox.Text += reader.ReadLine() + "\r\n";
                reader.Close();
            }
        }
    }
}
