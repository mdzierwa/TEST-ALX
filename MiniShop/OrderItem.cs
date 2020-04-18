﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class OrderItem
    {
        private Product product;
        private int qnty;

        public double ProductPrice { get { return product.Price; } }
        public double Qnty { get { return qnty; } }

        public OrderItem(Product product, int qnty)
        {
            this.product = product;
            this.qnty = qnty;
        }
    }
}
