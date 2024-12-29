namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookieIndexer();
            cookie["name"] = "Janardhan";
            Console.WriteLine(cookie["name"]);
        }

        static void useProperty()
        {
            var personProperty = new PersonProperty(new DateTime(2003, 12, 11));
            Console.WriteLine(personProperty.Age);
        }

        static void useAccessModifiers()
        {
            var p1 = new PersonAccessModifier();
            p1.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(p1.GetBirthDate());
        }

        static void useCustomerField()
        {
            var customerField = new CustomerFields(1);
            customerField.Orders.Add(new OrderFields());
            customerField.Orders.Add(new OrderFields());

            Console.WriteLine(customerField.Orders.Count);

            customerField.Promote();
            Console.WriteLine(customerField.Orders.Count);

        }

        static void outKeyword()
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result) Console.WriteLine(number);
            else Console.WriteLine("Conversion Failed");
        }

        static void useCalculator()
        {
            var normalCal = new Calculator();
            Console.WriteLine(normalCal.Add(5, 7, 8, 9, 44, 22, 5));
        }

        static void useCustomer()
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Janardhan";
            var order = new Order();
            customer.Orders.Add(order);
        }

        static void usePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at {0} {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0} {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occoured");
            }

        }
    }
}