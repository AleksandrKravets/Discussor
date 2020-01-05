﻿using System.Threading.Tasks;

namespace Infrastructure.Contracts
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
