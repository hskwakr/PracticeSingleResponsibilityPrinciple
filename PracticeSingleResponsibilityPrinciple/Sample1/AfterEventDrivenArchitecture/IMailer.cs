namespace PracticeSingleResponsibilityPrinciple.Sample1.AfterEventDrivenArchitecture
{
    public interface IMailer
    {
        void Send(Order order);
    }
}
