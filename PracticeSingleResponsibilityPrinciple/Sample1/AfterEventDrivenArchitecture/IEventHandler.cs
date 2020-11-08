using PracticeSingleResponsibilityPrinciple.Sample1.AfterEventDrivenArchitecture.Events;

namespace PracticeSingleResponsibilityPrinciple.Sample1.AfterEventDrivenArchitecture.EventHandlers
{
    public interface IEventHandler<T> where T: OrderCreated
    {
        void Handle(OrderCreated evt);
    }
}
