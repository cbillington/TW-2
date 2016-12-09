using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW_2
{
    public class Package
    {


        public string PackageId { get; set; }

        public string PkgLocation { get; set; }

        public string PkgName { get; set; }

        public DateTime PkgStartDate { get; set; }

        public DateTime PkgEndDate { get; set; }

        public string PkgDesc { get; set; }

        public double PkgBasePrice { get; set; }

        public double PkgAgencyCommission { get; set; }

        public bool PackageExpired
        {
            get
            {
                // When asked if the package is expired, compare the package start date to the current date

                var currentDate = DateTime.Now;  // gives the current date

                if ( PkgStartDate > currentDate )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public List<Product> Products { get; set; }

        // AddProduct() should take a product(s) as an input, and add the product(s) to the list of products Products

        public void AddProduct( Product product )
        {
            // add the product to the list of products
            Products.Add( product );
        }

        public void AddProducts( List<Product> products )
        {
            // loop over each product
            foreach( Product product in products )
            {
                // add the product to the Products list
                Products.Add( product );
            }
        }

        // CalcTotal() takes no parameters and returns a number that corresponds to the total price of the package

        public double CalcTotalPrice()
        {
            double packageTotal = 0; // total price of package after the addition of products
            double productsPriceTotal = 0; // total price of all products added to the package
            
            // calculate the total price of all products added to the package
            foreach( Product product in Products )
            {
                productsPriceTotal = product.Price;
            }
 
            packageTotal = PkgBasePrice + productsPriceTotal;

            return packageTotal;
        }



    }
}
