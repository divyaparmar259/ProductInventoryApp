using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventoryConsoleApp
{
    public class Product
    {
       
        string productName;
        float productPrice;
        
        Dictionary<string,float> Product1 = new Dictionary<string, float>();
        public Product (string productName,float productPrice)
        {
           this.productName = productName;
           this.productPrice = productPrice;
           
        }

        public void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("How many Products do you want to add");
            int totalcount = Int32.Parse(Console.ReadLine());

            for(int i =1;i<=totalcount;i++)
            {               
                Console.WriteLine("Enter ProductName");
                productName = Console.ReadLine();
                Console.WriteLine("Enter ProductPrice");
                productPrice = Int32.Parse(Console.ReadLine());


                Product1.Add(productName, productPrice);
                Console.WriteLine("Product Successfully Added..");
                
            }
            Console.WriteLine("");

        }
        public void SearchProduct()
        {
            Console.Clear();
            Console.WriteLine("Do you want to Search Any Product then");
            Console.WriteLine("Enter ProductName :");

            string oldProduct = Console.ReadLine();
            if(Product1.ContainsKey(""+oldProduct))
            {
                Console.WriteLine("Product Found :");
                Console.WriteLine(oldProduct);

             }
            else
            {
                Console.WriteLine("Product is not Available");
            }
            Console.WriteLine("");
        }

        public void CountProduct()
        {
            Console.Clear();
            Console.WriteLine("Total Count of Product");
            Console.WriteLine(Product1.Count);
            Console.WriteLine("");

        }
        public void ListAllProduct()
        {
            Console.Clear();
            Console.WriteLine("List of All Products available in Stock");
            foreach (KeyValuePair< string,float> a in Product1)
            {
                Console.WriteLine("ProductName:{0},ProductPrice:{1}", a.Key, a.Value);
            }
            Console.WriteLine("");
        }
    }
}
