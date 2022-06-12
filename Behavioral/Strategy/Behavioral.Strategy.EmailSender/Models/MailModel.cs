namespace Behavioral.Strategy.EmailSender.Models;

public class MailModel
{
    public MailModel()
    {

    }

    public string? Email { get; set; }
    public string? Subject { get; set; }
    public EMailServiceType MailServiceType { get; set; }

}
