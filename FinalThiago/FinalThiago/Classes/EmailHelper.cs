using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FinalThiago.Classes
{
	public static class EmailHelper
	{
		public static void SendEmail(string email)
		{
			MailMessage mail = new MailMessage();
			SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

			mail.From = new MailAddress("lucariuzx@gmail.com");
			mail.To.Add(email);
			mail.Subject = "Reenvio de senha";


			string bodyMail = @"
                    <p>Sua nova senha é 456. Peça ao seu gerente para atualizá-la ou atualize se você for gerente.</p>";

			mail.Body = bodyMail;
			mail.IsBodyHtml = true;

			SmtpServer.UseDefaultCredentials = false;
			SmtpServer.Port = 587;
			SmtpServer.Credentials = new System.Net.NetworkCredential("Lucariuzx@gmail.com", "Ll22428712");
			SmtpServer.EnableSsl = true;

			SmtpServer.Send(mail);
		}

	}
}

