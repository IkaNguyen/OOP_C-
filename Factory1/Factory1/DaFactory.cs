using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factory1
{
    public abstract class DaFactory
    {
        public abstract IFactory Create(IceCreamType type);
        public enum IceCreamType
        {
            Strawberry, Chocolate, Vanilla,
        }
    }
}
