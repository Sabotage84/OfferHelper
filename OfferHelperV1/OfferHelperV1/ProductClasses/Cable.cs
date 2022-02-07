using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    public class Cable:Product
    {
        public Cable(int dt = 40, TypeOfProduct t = TypeOfProduct.Cable):base(dt,t)
        {
            
        }

        public Cable(int id, int dt = 40, TypeOfProduct t = TypeOfProduct.Cable):base(id,dt,t)
        {

        }
        public Cable()
        {

        }
    }
}
