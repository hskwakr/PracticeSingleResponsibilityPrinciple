namespace PracticeSingleResponsibilityPrinciple.Sample1.AfterEventDrivenArchitecture
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public void Create()
        {
            // fill the Order entity using the full power of our Business Logic(discounts, promotions, etc.)
            var order = new Order();

            _repository.Save(order);
        }
    }
}
