﻿using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Web.Services
{
	public class EmailSender : IEmailSender
	{
		private string _smtpServer;
		private int _smtpPort;
		private string _fromEmailAdress;

		public EmailSender(string smtpServer, int smtpPort, string fromEmailAdress)
		{
			this._smtpServer = smtpServer;
			this._smtpPort = smtpPort;
			this._fromEmailAdress = fromEmailAdress;
		}

		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			var message = new MailMessage
			{
				From = new MailAddress(_fromEmailAdress),
				Subject = subject,
				Body = htmlMessage,
				IsBodyHtml = true
			};

			message.To.Add(new MailAddress(email));

			using var client = new SmtpClient(_smtpServer, _smtpPort);
			client.Send(message);

			return Task.CompletedTask;
		}
	}
}
