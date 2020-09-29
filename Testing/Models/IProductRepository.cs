using System;
using System.Collections.Generic;

namespace Testing.Models

{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(); //Stubbed out method
        void CreateProduct(string name, double price, int categoryID);
        public Product GetProduct(int id);
        public void UpdateProduct(Product p);

        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();

        public Product AssignCategory();
        public void DeleteProduct(Product product);
    }
}
