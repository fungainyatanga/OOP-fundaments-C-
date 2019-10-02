using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
   public class Product : EntityBase, ILoggable
    {
        private string _productName;

        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string ProductName
        {
            get
            {

                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        //adding logging  
        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        //override to make  debugging easier  provides information
        public override string ToString() => ProductName;
        //Validates  product data
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }


    }
}
