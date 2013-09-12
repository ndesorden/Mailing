using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Mailing
{
    class Mail
    {
        private MailMessage message;
        private string fromEmail;
        private string[] toEmail;
        private string subject;
        private string body;
        private string smtpServer;
        private int smtpPort;
        private string[] credential;
        private string[] attachments;
        private string[,] linkedResources;
        private bool isHtml;
        private bool isBcc;
        private string templateFile;
        private string templateMarker;

        public Mail(string fromEmail, string[] toEmail, string subject, string body, string smtpServer)
        {
            this.fromEmail = fromEmail;
            this.toEmail = toEmail;
            this.subject = subject;
            this.body = body;
            this.smtpServer = smtpServer;
        }

        public string SmtpServer
        {
            get { return smtpServer; }
            set { smtpServer = value; }
        }

        public int SmtpPort
        {
            get { return smtpPort; }
            set { smtpPort = value; }
        }

        public string[] Credential
        {
            get { return credential; }
            set { credential = value; }
        }

        public string[] Attachments
        {
            get { return attachments; }
            set { attachments = value; }
        }


        public string[,] LinkedResources
        {
            get { return linkedResources; }
            set { linkedResources = value; }
        }

        public bool IsHtml
        {
            get { return isHtml; }
            set { isHtml = value; }
        }

        public bool IsBcc
        {
            get { return isBcc; }
            set { isBcc = value; }
        }

        public string TemplateFile
        {
            get { return templateFile; }
            set { templateFile = value; }
        }

        public string TemplateMarker
        {
            get { return templateMarker; }
            set { templateMarker = value; }
        }

        public void buildMessage()
        {

            string toEmail = string.Join(", ", this.toEmail);

            if (this.templateFile != null && File.Exists(this.templateFile))
            {
                // Carga plantilla
                string html = File.ReadAllText(this.templateFile, Encoding.GetEncoding("iso-8859-1"));

                // Reemplazo
                StringBuilder htmlSB = new StringBuilder(html);
                htmlSB = htmlSB.Replace(this.templateMarker, this.body);

                // Asignamos el texto con template
                this.body = htmlSB.ToString();
            }

            this.message = new MailMessage();
            this.message.From = new MailAddress(this.fromEmail);
            if (this.isBcc == false)
            {
                this.message.To.Add(toEmail);
            }
            else
            {
                this.message.Bcc.Add(toEmail);
            }
            this.message.Subject = this.subject;
            this.message.Body = this.body;
            this.message.IsBodyHtml = this.isHtml;

            if (this.attachments != null)
            {
                Attachment attachment;
                foreach (string fileAttach in this.attachments)
                {
                    attachment = new Attachment(fileAttach);
                    message.Attachments.Add(attachment);
                }
            }

            if (this.linkedResources != null)
            {
                AlternateView av1 = AlternateView.CreateAlternateViewFromString(this.message.Body, null, System.Net.Mime.MediaTypeNames.Text.Html);
                LinkedResource lr;
                for (int i = 0; i < this.LinkedResources.GetLength(0); i++)
                {
                    lr = new LinkedResource(this.linkedResources[i,1]);
                    lr.ContentId = this.linkedResources[i, 0];
                    av1.LinkedResources.Add(lr); 
                }
                this.message.AlternateViews.Add(av1);
            }

        }

        public void Send()
        {
            SmtpClient smtpMail;
            if (this.smtpPort > 0)
            {
                smtpMail = new SmtpClient(this.SmtpServer, this.smtpPort);
            }
            else
            {
                smtpMail = new SmtpClient(this.SmtpServer);
            }

            if (this.credential == null)
            {
                smtpMail.Credentials = CredentialCache.DefaultNetworkCredentials;
            }
            else
            {
                smtpMail.Credentials = new NetworkCredential(this.credential[0], this.credential[1]);
            }

            smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtpMail.Send(this.message);
        }
    }
}
