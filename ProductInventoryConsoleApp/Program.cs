using System;

namespace ProductInventoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product("proname",1);
            repeat:
            Console.WriteLine("Product Inventory System");
            Console.WriteLine("Choose any One");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Search Product");
            Console.WriteLine("3. Count Product");
            Console.WriteLine("4. List All the Product");
            Console.WriteLine("5. Exit");

            int choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    product.AddProduct();
                    goto repeat;
                    
                case 2:
                    product.SearchProduct();
                    goto repeat;
                case 3 :
                    product.CountProduct();
                    goto repeat;
                case 4:
                    product.ListAllProduct();
                    goto repeat;
                case 5:
                    break;
                default:
                    Console.WriteLine("Choose From the above only");
                    goto repeat;

            }
        }
    }
}
