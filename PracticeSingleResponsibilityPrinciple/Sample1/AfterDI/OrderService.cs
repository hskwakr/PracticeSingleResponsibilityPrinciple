namespace PracticeSingleResponsibilityPrinciple.Sample1.AfterDI
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _repository;
        private IMailer _mailer;

        public OrderService(IOrderRepository repository, IMailer mailer)
        {
            _repository = repository;
            _mailer = mailer;
        }

        public void Create()
        {
            // fill the Order entity using the full power of our Business Logic(discounts, promotions, etc.)
            var order = new Order();

            _repository.Save(order);

            _mailer.Send(order.to, order.from, order.body);
        }
    }
}
