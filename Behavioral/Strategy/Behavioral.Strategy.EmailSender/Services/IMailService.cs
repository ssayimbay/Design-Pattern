using Behavioral.Strategy.EmailSender.Models;

namespace Behavioral.Strategy.EmailSender.Services;

public interface IMailService
{
    Task<bool> SendEmailAsync(MailModel mailModel);
}
