using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    public class Antenna:Product
    {
        public Antenna(int dt = 40, TypeOfProduct t = TypeOfProduct.Antenna) :base(dt, t)
        {
           
        }

        public Antenna(int id, int dt = 40, TypeOfProduct t = TypeOfProduct.Antenna) : base(id, dt, t)
        {

        }

        public Antenna()
        {

        }

    }
}
