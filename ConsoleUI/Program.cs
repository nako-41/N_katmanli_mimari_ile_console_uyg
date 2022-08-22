using Business.Concrete;
using DataAccess.Concrete.Inmemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager pmg = new ProductManager(new InMemoryProductDal());
            List<Product> result = pmg.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
