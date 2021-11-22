using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    class Services:Product
    {
        public Services(int dt = 20, TypeOfProduct t = TypeOfProduct.Service) : base(dt, t)
        {

        }

        public Services(int id, int dt = 20, TypeOfProduct t = TypeOfProduct.Service) : base(id, dt, t)
        {

        }
    }
}
