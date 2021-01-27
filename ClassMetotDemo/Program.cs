using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers()
            {
                Id = 1,
                FirstName = "Ahmet",
                LastNAme = "Şengül"
            };
            Customers customer2 = new Customers()
            {
                Id = 1,
                FirstName = "Furkan",
                LastNAme = "Kavak"
            };
        }
    }
}
