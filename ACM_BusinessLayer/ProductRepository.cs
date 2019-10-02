using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            //Code that retrieves the defined product  
            //temporary hard coded values to return  this is in-memory data 

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "assosrted size set of 4 bright yellow sunflowers";
                product.CurrentPrice = 153.96m;

            }
            object myObject = new object();
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }
            //Saves the current customer  

            public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.isValid)
                {
                    if (product.IsNew)
                    {
                        //call a insert stored procedure  
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            
            return success;
        }
    }
}
