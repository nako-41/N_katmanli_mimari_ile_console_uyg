using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    //burası şöyle urun varlıgımla ilgili yapacagım operasyonlar buradan yapılacak CRUD işlemler.bu interface urune özel
    
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
        List<Product> GetAllByProduct(int productId);

    }
}
