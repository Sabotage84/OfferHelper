using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    class Antenna:Product
    {
        public Antenna()
        {
            Type = TypeOfProduct.Antenna;
            DeliveryTime = 15;
        }
    }
}
