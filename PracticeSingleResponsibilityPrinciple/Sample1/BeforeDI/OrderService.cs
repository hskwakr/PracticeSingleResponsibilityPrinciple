namespace PracticeSingleResponsibilityPrinciple.Sample1.BeforeDI
{
    public class OrderService
    {
        public void Create()
        {
            // Creating the order(and let’s forget about reserving here, it’s not important for following examples)

            // Sending an email to client with order details
            var smtp = new SMTP();
            // Setting smtp.Host, UserName, Password and other parameters
            smtp.Send();
        }
    }
}
