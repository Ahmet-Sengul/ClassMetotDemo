using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        static void AddCustomer(Customers customer)
        {
            Console.WriteLine("Customer Added!");
        }
        static void ListCostumer(Customers customer)
        {
            Console.WriteLine("Customer Listed!");
        }
        static void DelCustomer(Customers customer)
        {
            Console.WriteLine("Customer Deleted!");
        }
    }
}
