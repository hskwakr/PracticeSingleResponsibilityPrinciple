namespace PracticeSingleResponsibilityPrinciple.Sample1.AfterDI
{
    public interface IMailer
    {
        void Send(string to, string subject, string body);
    }
}
