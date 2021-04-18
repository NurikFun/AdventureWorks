using AdventureWorks.ADO.NET;
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

            using (AdventureWorksContext adventureWorks = new AdventureWorksContext())
            {
                foreach (Product product in adventureWorks.Product)
                {
                    Console.WriteLine($"Name : {product.Name}, Product Number : {product.ProductNumber}");
                }
            }

            Console.ReadKey();
        }
    }
}
