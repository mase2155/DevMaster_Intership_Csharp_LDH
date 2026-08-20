using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex06.ProductCollections.Interfaces;
using Ex06.ProductCollections.Models;


namespace Ex06.ProductCollections.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> _products = new();
        private readonly Dictionary<string, Product> _productByID = new();

        public void Add(Product entity)
        {
            if (_productByID.ContainsKey(entity.ProductID))
            {
                throw new InvalidOperationException(
                    $"Mã sản phẩm {entity.ProductID} đã tồn tại .");
            }

            _products.Add(entity);
            _productByID.Add(entity.ProductID, entity);
        }

        public bool Delete(string id)
        {
            if (!_productByID.TryGetValue(id, out var product))
                return false;

            _products.Remove(product);
            _productByID.Remove(id);
            return true;
        }

        public IReadOnlyList<Product> GetAll()
        {
            return _products.AsReadOnly();
        }

        public Product? GetByID(string id)
        {
            _productByID.TryGetValue(id, out var product);
            return product;
        }

        public bool Update(Product entity)
        {
            if (!_productByID.TryGetValue(entity.ProductID, out var existing))
                return false;
            existing.ProductName = entity.ProductName;
            existing.Category = entity.Category;
            existing.Price = entity.Price;
            existing.Quantity = entity.Quantity;
            existing.Supplier = entity.Supplier;
            existing.Tags = entity.Tags;
            return true;
        }
    }
}
