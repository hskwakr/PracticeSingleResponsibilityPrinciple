using PracticeSingleResponsibilityPrinciple.Sample1.AfterEventDrivenArchitecture.Events;

namespace PracticeSingleResponsibilityPrinciple.Sample1.AfterEventDrivenArchitecture.EventHandlers
{
    public class OrderCreatedEmailSender : IEventHandler<OrderCreated>
    {
        private IMailer _mailer;

        public OrderCreatedEmailSender(IMailer mailer)
        {
            _mailer = mailer;
        }

        public void Handle(OrderCreated evt) => _mailer.Send(evt.GetOrder());
    }
}
