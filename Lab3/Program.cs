using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();
            TesTOneToMany();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                string firstName = Console.ReadLine();
                string middleName = Console.ReadLine();
                string lastName = Console.ReadLine();
                string phoneNumber = Console.ReadLine();
                Person p = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MiddleName = middleName,
                    TelephonNumber = phoneNumber
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }
        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            using (ModelOneToManyContainer context =
           new ModelOneToManyContainer())
            {
                Customer c = new Customer()
                {
                    Name = Console.ReadLine(),
                    City = Console.ReadLine()
                };
                Order o1 = new Order()
                {
                    TotalValue = Int32.Parse(Console.ReadLine()),
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = Int32.Parse(Console.ReadLine()),
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }

    }
}
