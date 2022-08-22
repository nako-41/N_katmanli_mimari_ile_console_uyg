﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategopryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public override string ToString()
        {
            return Id + " " + CategopryId + " " + ProductName + " " + UnitsInStock + " " + UnitPrice;
        }

    }
}
