using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Inmemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>() 
            {
                new Product{Id=1,CategopryId=1,ProductName="masa",UnitPrice=15,UnitsInStock=10 }, 
                new Product{Id=2,CategopryId=2,ProductName="dolat",UnitPrice=30,UnitsInStock=20 }, 
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var result = _products.FirstOrDefault(x=>x.Id==product.Id);
            _products.Remove(result);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.Id==categoryId).ToList();
        }

        public List<Product> GetAllByProduct(int productId)
        {
            return _products.Where(x=>x.Id==productId).ToList();
        }

        public void Update(Product product)
        {
            var result = _products.SingleOrDefault(x=>x.Id==product.Id);
            result.ProductName = product.ProductName;
            result.CategopryId = product.CategopryId;
            result.UnitPrice = product.UnitPrice;
            result.UnitsInStock = product.UnitsInStock;
           
        }
    }
}
