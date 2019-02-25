namespace EmailServices.Core
{
    public interface IEmailService
    {
        EmailResult SendEmail(string name, string email, string subject, string body);
    }
}