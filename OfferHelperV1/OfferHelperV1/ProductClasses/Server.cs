using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    [Serializable]
    public class Server:Product
    {
        public Server(int dt = 40, TypeOfProduct t = TypeOfProduct.Server) : base(dt, t)
        {

        }

        public Server(int id, int dt = 40, TypeOfProduct t = TypeOfProduct.Server) : base(id, dt, t)
        {

        }

        public Server()
        {

        }

    }
}
