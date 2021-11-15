using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    class Services:Product
    {
        public Services()
        {
            Type = TypeOfProduct.Service;
            DeliveryTime = 20;
        }
    }
}
