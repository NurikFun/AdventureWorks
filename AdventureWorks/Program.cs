using AdventureWorks.ADO.NET;
using AdventureWorks.Repository.ModelRepository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorkContext adventureWorks = new AdventureWorkContext();
            ProductRepository repository = new ProductRepository(adventureWorks);

            /*
            var values = repository.GetList();
            foreach (var item in values)
            {
                Console.WriteLine($"Name : {item.Name}, Product Number : {item.ProductNumber}");
            }
           */

            /*
            var values = repository.Get(1);

            Console.WriteLine($"Name : {values.Name}, Product Number : {values.ProductNumber}");
            */

            /*
            repository.Create(new Product { Name = "Github", ProductNumber = "JS-580", MakeFlag = true,
                FinishedGoodsFlag = true, SafetyStockLevel = 1200, ReorderPoint = 900,
                StandardCost = 0, ListPrice = 0, DaysToManufacture = 0, 
                SellStartDate = new DateTime(2008, 04, 30, 0, 0, 0), SellEndDate = new DateTime(2008, 05, 30, 0, 0, 0),
                rowguid = Guid.NewGuid(), ModifiedDate = new DateTime(2008, 05, 30, 0, 0, 0)
            });
            repository.Save();
            var values = repository.GetList().OrderByDescending(p => p.ProductID).FirstOrDefault();
            Console.WriteLine($"Name : {values.Name}, Product Number : {values.ProductNumber}");
            */

            /*
            var values = repository.GetList().OrderByDescending(p => p.ProductID).FirstOrDefault();
            values.Name = "Github updated";
            repository.Update(values);
            repository.Save();
            values = repository.GetList().OrderByDescending(p => p.ProductID).FirstOrDefault();
            Console.WriteLine($"Name : {values.Name}, Product Number : {values.ProductNumber}");
            */

          

            Expression<Func<Product, bool>> expression = x => x.Name == "Github updated";

            var values = repository.GetList(expression);

            foreach (var value in values)
            {
                Console.WriteLine($"Name : {value.Name}, Product Number : {value.ProductNumber}");
            }

            repository.Dispose();
            

            Console.ReadKey();
        }
    }
}