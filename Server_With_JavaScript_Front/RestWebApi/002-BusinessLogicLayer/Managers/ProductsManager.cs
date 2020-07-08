using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWebApi
{
	public class ProductsManager: IProductsRepository
	{
		static List<Product> arrProducts = new List<Product> {
			new Product {id=1,name="bamba", price=5 },
			new Product {id=2,name="bread", price=5 },
			new Product {id=3,name="milk", price=6 },
			new Product {id=4,name="bisli", price=7 },
			new Product {id=5,name="banana", price=12 }
		};

		public List<Product> GetAllProducts()
		{
			return arrProducts;
		}

		public Product GetProductById(int id)
		{
			if (id < 0)
				throw new ArgumentOutOfRangeException();
			Product p = arrProducts.FirstOrDefault(p1 => p1.id == id);
			return p;
		}

		public Product GetProductByPrice(double price)
		{
			if (price < 0)
				throw new ArgumentOutOfRangeException();
			Product p = arrProducts.FirstOrDefault(p1 => p1.price == price);
			return p;
		}

		public Product PostProduct(Product value)
		{
			arrProducts.Add(value);
			return GetProductById(value.id);
		}

		public Product PutProduct(int id, Product value)
		{
			Product p1 = arrProducts.FirstOrDefault(p => p.id == id);
			if (p1 != null)
			{
				p1.price = value.price;
				return GetProductById(value.id);
			}
			return null;
		}

		public bool DeleteProduct(int id)
		{
			Product p = arrProducts.FirstOrDefault(p1 => p1.id == id);
			arrProducts.Remove(p);

			Product pr = GetProductById(id);

			if (pr == null)
				return true;
			else
				return false;
		}
	}
}
