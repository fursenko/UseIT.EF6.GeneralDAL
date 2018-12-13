
namespace GeneralDAL.App
{
    using GeneralDAL.Common;
    using GeneralDAL.Service;
    using System;
    using System.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cs = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
                var service = new ProductDataService(cs);

                for (int i = 0; i < 10; i++)
                {
                    var product = new ProductDTO();
                    product.Id = i;
                    product.Name = String.Format("Product_{0}", i);

                    service.Add(product);
                    Console.WriteLine("Product {0} added", i);
                }

                Console.WriteLine("Get all products");

                var products = service.GetAll();

                foreach (var product in products)
                    Console.WriteLine("Product '{0}' is retrieved", product.Name);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
