using System;
using System.Linq;

namespace Get_Property_using_Reflection
{
    class Product
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product oneProduct = new Product { Name = "Apple" };

            string productName = oneProduct.GetType().GetProperties().First(
                prop => prop.Name == "Name").GetValue(oneProduct).ToString();

            Console.WriteLine(productName);
        }
    }
}
