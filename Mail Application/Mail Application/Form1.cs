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
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Net.Mail;


namespace Mail_Application
{
    public partial class Form1 : Form
    {
        private List<string> emailList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void addfilebutton_Click(object sender, EventArgs e)
        {
            // Öppna filutforskaren för att välja en CSV-fil
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Läs in den valda CSV-filen
                string filePath = openFileDialog.FileName;

                // Läs in e-postadresser från filen
                ReadEmailsFromFile(filePath);

                // Visa antalet e-postadresser som lästs in
                MessageBox.Show($"Number of email addresses read from file: {emailList.Count}");
            }
        }

        private void ReadEmailsFromFile(string filePath)
        {
            // Återställ listan över e-postadresser
            emailList.Clear();

            // Läs in e-postadresser från CSV-filen
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    foreach (string part in parts)
                    {
                        string email = part.Trim();

                        if (!IsValidEmail(email))
                        {
                            MessageBox.Show($"Invalid e-mail address: {email}");
                            emailList.Clear();
                            return;
                        }

                        // Lägg till varje del som en e-postadress
                        emailList.Add(part.Trim());
                    }
                }
            }
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            string senderEmail = ConfigurationManager.AppSettings.Get("mail");
            string senderPassword = ConfigurationManager.AppSettings.Get("password");
            string subject = subjecttextbox.Text.Trim();
            string message = messagetextbox.Text;
            
            DialogResult result = MessageBox.Show("Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kontrollera användarens svar
            if (result == DialogResult.Yes)
            {
                // Om användaren klickar på "Ja", gör något här
                MessageBox.Show("Good! You Are Sure");
            }
            else
            {
                // Om användaren klickar på "Nej" eller stänger fönstret, gör något annat här
                MessageBox.Show("Okej, No Problem");
                return;

            }

            if (emailList.Count() == 0)
            {
                MessageBox.Show("There are no emails to send to");
            }

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please fill in alla fields: (avsändarens e-postadress, ämne och meddelande).");
                return;
            }

            // Loopa igenom och validera varje e-postadress
            foreach (string email in emailList)
            {
                // Om e-postadressen är korrekt, skicka e-post
                SendEmail(senderEmail, senderPassword, email, subject, message);
            }
        }

        private bool IsValidEmail(string email)
        {
            // Använd det nya reguljära uttrycket för att validera e-postadressen
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }

        private void SendEmail(string senderEmail, string senderPassword, string recipient, string subject, string message)
        {
            string smtpClient = ConfigurationManager.AppSettings.Get("smtpclient");

            try
            {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient(smtpClient);
                mm.From = new MailAddress(senderEmail);
                mm.To.Add(recipient);
                mm.Subject = subject;
                mm.Body = message;
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);
                sc.EnableSsl = true;
                sc.Send(mm);


                string mailHistory = $"Datum och tid: {DateTime.Now}\nFrån: {senderEmail}\nTill: {recipient}\n";
                SaveMailHistory(mailHistory);

                MessageBox.Show($"Mail has been sent to: {recipient}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show($"Error when sending to: {recipient}: {ex.Message}");
            }
        }
        private void SaveMailHistory(string mailHistory)
        {
            string filePath = "mailhistory.txt";

            // Skriv mailhistoriken till textfilen
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(mailHistory);
            }
        }

        private void subjecttextbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void messagetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            string filePath = "mailhistory.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the content of the file and display it in a message box
                string fileContent = File.ReadAllText(filePath);
                MessageBox.Show(fileContent, "Mail History");
            }
            else
            {
                // If the file doesn't exist, show an error message
                MessageBox.Show("There is no history yet.", "Error");
            }
        }
    }
}
