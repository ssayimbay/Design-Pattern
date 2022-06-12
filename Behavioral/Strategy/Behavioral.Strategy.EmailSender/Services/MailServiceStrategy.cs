using Behavioral.Strategy.EmailSender.Models;

namespace Behavioral.Strategy.EmailSender.Services;

public class MailServiceStrategy
{
    private IMailService? _mailService;

    public async Task<bool> SendMailAsync(MailModel mailModel)
    {
        _mailService = mailModel.MailServiceType switch
        {
            EMailServiceType.XMail => new XMailService(),
            EMailServiceType.YMail => new YMailService(),
            EMailServiceType.ZMail => new ZMailService(),
            _ => new XMailService()
        };

        return await _mailService.SendEmailAsync(mailModel);
    }
}
