namespace PracticeSingleResponsibilityPrinciple.Sample1.After.ApplySRP
{
    public class OrderController
    {
        private OrderService _service;

        public OrderController()
        {
            _service = new OrderService();
        }

        [HttpPost]
        public ActionResult Create(OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                // View data preparations

                return View();
            }

            _service.Create(request);

            return RedirectToAction("Index");
        }

        public ActionResult View() => new ActionResult();
        public ActionResult RedirectToAction(string name) => new ActionResult();
    }
}
