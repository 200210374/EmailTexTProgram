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
    public partial class saveRecordForm : Form
    {
        public saveRecordForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            string path = "PhoneNumbers.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = Environment.NewLine + "Name: " + nameTextbox.Text + Environment.NewLine +
                    "Phone number: " + phoneNumberTextBox.Text + Environment.NewLine + "Email: " + emailTextBox.Text + Environment.NewLine + PhoneCarrierTextBox.Text + Environment.NewLine;




                File.WriteAllText(path, createText);
            }
            else
            {

                string appendText = Environment.NewLine + "Name: " + nameTextbox.Text + Environment.NewLine +
                        "Position: " + phoneNumberTextBox.Text + Environment.NewLine + "Email: " + emailTextBox.Text + Environment.NewLine + PhoneCarrierTextBox.Text + Environment.NewLine;

                File.AppendAllText(path, appendText);

                MessageBox.Show("Record saved");
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
    }
}
