using System.Collections.Generic;

namespace RestWebApi
{
	public interface IProductsRepository
	{
		List<Product> GetAllProducts();
		Product GetProductById(int id);
		Product GetProductByPrice(double price);
		Product PostProduct(Product value);
		Product PutProduct(int id, Product value);
		bool DeleteProduct(int id);
	}
}
