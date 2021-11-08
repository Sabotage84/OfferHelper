using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    class Cable:Product
    {
        public Cable()
        {
            Type = TypeOfProduct.Cable;
            DeliveryTime = 40;
        }
    }
}
