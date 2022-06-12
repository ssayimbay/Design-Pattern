using Behavioral.Strategy.EmailSender.Models;

namespace Behavioral.Strategy.EmailSender.Services;

public class YMailService : IMailService
{
    public Task<bool> SendEmailAsync(MailModel mailModel)
    {
        Console.WriteLine("#################################");
        Console.WriteLine($"Mail    : {mailModel.Email}");
        Console.WriteLine($"Subject : {mailModel.Subject}");
        Console.WriteLine($"Service : {this.GetType().Name}");
        Console.WriteLine("#################################\n");
        return Task.FromResult(true);
    }
}
