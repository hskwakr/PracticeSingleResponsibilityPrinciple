namespace PracticeSingleResponsibilityPrinciple.Sample1.Before
{
    public class OrderController
    {
        public ActionResult CreateForm() => View();

        public ActionResult Create(OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                // View data preparations
                return View();
            }

            using (var context = new DataContext())
            {
                var order = new Order();
                // Create order from request
                context.Orders.Add(order);

                // Reserve ordered goods
                // ...(Huge logic here)...

                context.SaveChanges();

                //Send email with order details for customer
            }

            return RedirectToAction("Index");
        }

        public ActionResult View() => new ActionResult();
        public ActionResult RedirectToAction(string name) => new ActionResult();
    }
}
