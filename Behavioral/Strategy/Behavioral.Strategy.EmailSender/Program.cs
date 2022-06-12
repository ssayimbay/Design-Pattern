using Behavioral.Strategy.EmailSender.Models;
using Behavioral.Strategy.EmailSender.Services;

var mailServiceStrategy = new MailServiceStrategy();

var xMailModel = new MailModel
{
    Email = "Test1@mail.com",
    Subject = "Test Subject - 1",
    MailServiceType = EMailServiceType.XMail
};

var yMailModel = new MailModel
{
    Email = "Test2@mail.com",
    Subject = "Test Subject - 2",
    MailServiceType = EMailServiceType.YMail
};

var zMailModel = new MailModel
{
    Email = "Test3@mail.com",
    Subject = "Test Subject - 3",
    MailServiceType = EMailServiceType.ZMail
};

Console.WriteLine("## Strategy Pattern for different email sender algorithm ##\n");

await mailServiceStrategy.SendMailAsync(xMailModel);
await mailServiceStrategy.SendMailAsync(yMailModel);
await mailServiceStrategy.SendMailAsync(zMailModel);

Console.ReadLine();
