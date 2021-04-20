using AdventureWorks.ADO.NET;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Agreement agreement = new Agreement();

            agreement.ClientAgreement("888866664321");

            using (AdventureWorkContext adventureWorks = new AdventureWorkContext())
            {
                foreach (Product product in adventureWorks.Products)
                {
                    Console.WriteLine($"Name : {product.Name}, Product Number : {product.ProductNumber}");
                }
            }

            Console.ReadKey();
        }
    }
}