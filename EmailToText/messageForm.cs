using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmailToText
{
    public partial class messageForm : Form
    {
        public messageForm()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
          //  this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://freecarrierlookup.com/");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {



           
        }

        private void messageForm_Load(object sender, EventArgs e)
        {


            
            cboCarrier.Items.Add("Bell Mobility");
            
            cboCarrier.Items.Add("Koodo");
            cboCarrier.Items.Add("Rogers");
            cboCarrier.Items.Add("AT&T");
            cboCarrier.Items.Add("Telus");
            cboCarrier.Items.Add("T-Mobile");
            cboCarrier.Items.Add("Verison");
            cboCarrier.Items.Add("CellularOne");
            cboCarrier.Items.Add("Cingular");
            cboCarrier.Items.Add("Nextel");
            cboCarrier.Items.Add("Omnipoint");
            cboCarrier.Items.Add("Qwest");
            cboCarrier.Items.Add("Sprint");
            cboCarrier.Items.Add("Virgin Mobile");
            cboCarrier.Items.Add("Virgin Canada");











        }

        private void mailServerTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        public void check()
            {
            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Username Textbox is empty");
            }

            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Password Textbox is empty");
            }

            if (String.IsNullOrEmpty(emailAccountComboBox.Text))
            {
                MessageBox.Show("Email account is empty");
            }
            if (String.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Phone number or email account type is empty");
            }
            if (String.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Phone number or email account type is empty");
            }


            else {

                //Sends the message if there are no problems
                sendText();
            }


        }

        public void sendText() {

            if (emailAccountComboBox.Text == "Hotmail")
            {


                MailMessage msg = new MailMessage();


                msg.To.Add(phoneNumberTextBox.Text + emailToPhoneTextBox.Text);

                msg.From = new MailAddress(usernameTextBox.Text, passwordTextBox.Text);
                msg.Subject = subjectTextBox.Text;
                msg.Body = messageTextBox.Text;
                msg.Priority = MailPriority.High;

                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);     /*"brandonroycstn@hotmail.com", "Lovecraft1");*/
                client.Port = 587;



                client.Host = mailServerTextBox.Text;
                client.EnableSsl = true;

                // come back to later                 System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));

                try
                {
                    client.Send(msg);
                    MessageBox.Show("Message sent!");

                }
                catch (Exception)
                {


                    MessageBox.Show("The Message was not sent there was an error. ");

                }

            }

            if (emailAccountComboBox.Text == "Yahoo")
            {


                MailMessage msg = new MailMessage();


                msg.To.Add(phoneNumberTextBox.Text + emailToPhoneTextBox.Text);

                msg.From = new MailAddress(usernameTextBox.Text, passwordTextBox.Text);
                msg.Subject = subjectTextBox.Text;
                msg.Body = messageTextBox.Text;
                msg.Priority = MailPriority.High;

                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);     /*"brandonroycstn@hotmail.com", "Lovecraft1"*/
                client.Port = 465;



                client.Host = mailServerTextBox.Text;
                client.EnableSsl = true;


                try
                {
                    client.Send(msg);
                    MessageBox.Show("Message sent!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Sending message: " + ex.Message);

                }
            }

            if (emailAccountComboBox.Text == "Gmail")
            {


                MailMessage msg = new MailMessage();


                msg.To.Add(phoneNumberTextBox.Text + emailToPhoneTextBox.Text);

                msg.From = new MailAddress(usernameTextBox.Text, passwordTextBox.Text);
                msg.Subject = subjectTextBox.Text;
                msg.Body = messageTextBox.Text;
                msg.Priority = MailPriority.High;

                SmtpClient client = new SmtpClient();
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);
                client.Port = 587;

                client.EnableSsl = true;



                client.Host = mailServerTextBox.Text;




                try
                {
                    client.Send(msg);
                    MessageBox.Show("Message sent!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Sending message: " + ex.Message);

                }
            }

        }





        private void sendTextbutton_Click(object sender, EventArgs e)
        {
            //Makes the check and if it succeeds, it will send the message.
            check();
        }

        private void cboCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCarrier.Text == "Bell Mobility") 
            {
                emailToPhoneTextBox.Text =  "@txt.bell.ca";

            }

            if (cboCarrier.Text == "Koodo")
            {
                emailToPhoneTextBox.Text = "@msg.telus.com";

            }

            if (cboCarrier.Text == "Rogers")
            {
                emailToPhoneTextBox.Text = "@pcs.rogers.com";

            }

            if (cboCarrier.Text == "AT&T")
            {
                emailToPhoneTextBox.Text = "@txt.att.net";

            }

            if (cboCarrier.Text == "Telus")
            {
                emailToPhoneTextBox.Text = "@msg.telus.com";

            }

            if (cboCarrier.Text == "T-Mobile")
            {
                emailToPhoneTextBox.Text = "@tmomail.net";

            }


            if (cboCarrier.Text == "Verison")
            {
                emailToPhoneTextBox.Text = "@vtext.com";

            }

            if (cboCarrier.Text == "Virgin Mobile")
            {
                emailToPhoneTextBox.Text = "@vmobl.com";

            }

            if (cboCarrier.Text == "Virgin Mobile Canada")
            {
                emailToPhoneTextBox.Text = "@vmobile.ca";

            }

            if (cboCarrier.Text == "CellularOne")
            {
                emailToPhoneTextBox.Text = "@mobile.celloneusa.com";

            }

            if (cboCarrier.Text == "Cingular")
            {
                emailToPhoneTextBox.Text = "@cingularme.com";

            }
            if (cboCarrier.Text == "Nextel")
            {
                emailToPhoneTextBox.Text = "@messaging.nextel.com";

            }

            if (cboCarrier.Text == "Omnipoint")
            {
                emailToPhoneTextBox.Text = "@omnipointpcs.com";

            }
            if (cboCarrier.Text == "Qwest")
            {
                emailToPhoneTextBox.Text = "@qwestmp.com";

            }
            if (cboCarrier.Text == "Sprint")
            {
                emailToPhoneTextBox.Text = "@messaging.sprintpcs.com";

            }
         



            //Later ifs for other Companies




        }

        private void emailAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emailAccountComboBox.Text == "Hotmail")
            {
                mailServerTextBox.Text = "smtp-mail.outlook.com";

            }

            if (emailAccountComboBox.Text == "Yahoo")
            {
                mailServerTextBox.Text = "smtp.mail.yahoo.com";

            }


            if (emailAccountComboBox.Text == "Gmail")
            {
                mailServerTextBox.Text = "smtp.gmail.com";

            }






        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            usernameTextBox.Clear();
            passwordTextBox.Clear();



            cboCarrier.SelectedIndex = -1;
            mailServerTextBox.Clear();
            emailAccountComboBox.SelectedIndex = -1;
            phoneNumberTextBox.Clear();
            emailToPhoneTextBox.Clear();


            subjectTextBox.Clear();
            messageTextBox.Clear();


        }

        private void listRecords_Click(object sender, EventArgs e)
        {
            recordForm recordForm = new recordForm();
            recordForm.Show();
        }
    }
}
