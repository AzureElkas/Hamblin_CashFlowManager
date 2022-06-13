﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class Invoice : IPayable
    {
        public Invoice(string partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }
        public LedgerType Type { get; }

        public decimal GetPayableAmount()
        {
            throw new NotImplementedException();
        }
        public string PartNumber { get; }
        public int Quantity { get; }
        public string PartDescription { get; }
        public decimal Price { get; }
    }
}