using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex06.ProductCollections.Models;
using Ex06.ProductCollections.Repositories;

namespace Ex06.ProductCollections.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repository;
        private readonly HashSet<string> _allTags = new();
        private readonly SortedDictionary<string ,List<Product> > _productsByCategory = new ();

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }
        public void AddProduct(Product product)
        {
            _repository.Add(product);

            foreach (var tag in product.Tags)
                _allTags.Add(tag);

            AddToCategory(product);
        }
        private void AddToCategory(Product product)
        {
            if (!_productsByCategory.TryGetValue(product.Category,out var products))
            {
                products = new List<Product>();
                _productsByCategory.Add(product.Category, products);
            }
            products.Add(product);
        }
        private void RebuildAuxiliaryCollections()
        {
            _allTags.Clear();
            _productsByCategory.Clear();

            foreach (var p in _repository.GetAll())
            {
                foreach ( var tag in p.Tags)
                {
                    _allTags.Add(tag);
                }
                AddToCategory(p);
            }
        }
        public bool UpdateProduct(Product product)
        {
            bool success = _repository.Update(product);
            if(success)
            {
                RebuildAuxiliaryCollections();
            }
            return success;
        }
        public bool DeleteProduct(string id)
        {
            bool success = _repository.Delete(id);
            if (success)
            {
                RebuildAuxiliaryCollections();
            }
            return success;
        }
        public bool CheckIDExists(string id)
        {
            return _repository.GetByID(id) != null;
        }
        public Product? GetByID(string id)
        {
            return _repository.GetByID(id);
        }
        public IReadOnlyList<Product> GetAllProducts()
        {
            return _repository.GetAll();
        }
        public List<Product> FilterByCategory(string category)
        {
            return _repository.GetAll()
                .Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Product> SortByPrice(bool ascending = true)
        {
            return ascending
                ? _repository.GetAll().OrderBy(p => p.Price).ToList()
                : _repository.GetAll().OrderByDescending(p => p.Price).ToList();
        }
        public decimal GetTotalInventoryValue()
        {
            return _repository.GetAll().Sum(p => p.Price * p.Quantity);
        }
        public void SeedSampleData()
        {
            var sampleList = new List<Product>
            {
                new() { ProductId = "P001", ProductName = "Laptop Dell Inspiron", Category = "Laptop", Price = 18500000m, Quantity = 10, Supplier = "Dell", Tags = new() { "laptop", "dell", "office" } },
                new() { ProductID = "P002", ProductName = "Laptop HP ProBook", Category = "Laptop", Price = 21000000m, Quantity = 5, Supplier = "HP", Tags = new() { "laptop", "hp", "business" } },
                new() { ProductID = "P003", ProductName = "Mouse Logitech M331", Category = "Mouse", Price = 450000m, Quantity = 20, Supplier = "Logitech", Tags = new() { "mouse", "silent", "wireless" } },
                new() { ProductID = "P004", ProductName = "Keyboard Logitech K120", Category = "Keyboard", Price = 250000m, Quantity = 30, Supplier = "Logitech", Tags = new() { "keyboard", "usb", "office" } },
                new() { ProductID = "P005", ProductName = "Monitor Dell 24", Category = "Monitor", Price = 4500000m, Quantity = 4, Supplier = "Dell", Tags = new() { "monitor", "ips", "fhd" } },
                new() { ProductID = "P006", ProductName = "Laptop Lenovo ThinkPad", Category = "Laptop", Price = 25000000m, Quantity = 3, Supplier = "Lenovo", Tags = new() { "laptop", "thinkpad", "workstation" } },
                new() { ProductID = "P007", ProductName = "Mouse Rapoo M100", Category = "Mouse", Price = 300000m, Quantity = 15, Supplier = "Rapoo", Tags = new() { "mouse", "bluetooth", "wireless" } },
                new() { ProductID = "P008", ProductName = "Keyboard Corsair K60", Category = "Keyboard", Price = 2500000m, Quantity = 6, Supplier = "Corsair", Tags = new() { "keyboard", "mechanical", "gaming" } },
                new() { ProductID = "P009", ProductName = "Monitor LG 27", Category = "Monitor", Price = 6500000m, Quantity = 2, Supplier = "LG", Tags = new() { "monitor", "2k", "144hz" } },
                new() { ProductID = "P010", ProductName = "Webcam Logitech C920", Category = "Webcam", Price = 1800000m, Quantity = 8, Supplier = "Logitech", Tags = new() { "webcam", "fhd", "streaming" } }
            };
        }
    }
    
}
