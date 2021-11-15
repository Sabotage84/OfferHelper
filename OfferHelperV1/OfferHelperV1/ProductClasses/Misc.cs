using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    class Misc:Product
    {
        public Misc()
        {
            Type = TypeOfProduct.Miscs;
            DeliveryTime = 60;
        }

        public Misc(int id, int delTime=60)
        {
            Type = TypeOfProduct.Miscs;
            ID = id;
            DeliveryTime = delTime;
        }




    }
}
