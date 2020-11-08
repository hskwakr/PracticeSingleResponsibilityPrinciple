namespace PracticeSingleResponsibilityPrinciple.Sample1.AfterEventDrivenArchitecture.Events
{
    public class OrderCreated
    {
        private readonly Order _order;

        public OrderCreated(Order order)
        {
            _order = order;
        }

        public Order GetOrder() => _order;
    }
}
