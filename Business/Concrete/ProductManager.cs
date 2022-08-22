using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Inmemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _IProductDal;
        public ProductManager(IProductDal ProductDal)
        {
            _IProductDal = ProductDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları var burada
            //yetkisi var mı gibi algoritmalar varsayalım sonrasında getall() etodu cagrılır.
            return _IProductDal.GetAll();   //DataAccess katmanından gelen service/interface 

           
        }
    }
} 
