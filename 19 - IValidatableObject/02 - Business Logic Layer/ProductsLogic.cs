using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace JohnBryce
{
    public class ProductsLogic : BaseLogic
    {
        public List<ProductModel> GetAllProducts()
        {
            return DB.Products.Select(p => new ProductModel {
                id = p.ProductID,
                name = p.ProductName,
                price = p.UnitPrice,
                stock = p.UnitsInStock
            }).ToList();
        }

        public ProductModel GetOneProduct(int id)
        {
            return DB.Products.Where(p => p.ProductID == id).Select(p => new ProductModel
            {
                id = p.ProductID,
                name = p.ProductName,
                price = p.UnitPrice,
                stock = p.UnitsInStock
            }).SingleOrDefault();
        }

        public ProductModel AddProduct(ProductModel productModel)
        {
            Product product = new Product {
                ProductName = productModel.name,
                UnitPrice = productModel.price,
                UnitsInStock = productModel.stock
            };

            DB.Products.Add(product);
            DB.SaveChanges();
            return GetOneProduct(product.ProductID);
        }

        public ProductModel UpdateProduct(ProductModel productModel)
        {
            //// Update without two database access:
            //Product product = new Product();
            //product.ProductID = productModel.id;
            //product.ProductName = productModel.name;
            //product.UnitPrice = productModel.price;
            //product.UnitsInStock = productModel.stock;
            //DB.Products.Attach(product);
            //DB.Entry(product).State = EntityState.Modified;
            //DB.SaveChanges();
            //return GetOneProduct(product.ProductID);

            // Update but with two database access:
            Product product = DB.Products.Where(p => p.ProductID == productModel.id).SingleOrDefault();
            if (product == null)
                return null;
            product.ProductName = productModel.name;
            product.UnitPrice = productModel.price;
            product.UnitsInStock = productModel.stock;
            DB.SaveChanges();
            return GetOneProduct(product.ProductID);
        }

        public void DeleteProduct(int id)
        {
            // Product product = DB.Products.Where(p => p.ProductID == id).SingleOrDefault();
            Product product = new Product { ProductID = id };
            DB.Products.Attach(product);
            if (product == null)
                return;
            DB.Products.Remove(product);
            DB.SaveChanges();
        }
    }
}
