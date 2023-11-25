using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory1
{
    class TaoFac : DaFactory
    {
        public override IFactory Create(IceCreamType type)
        {
            switch (type) 
            {
                case IceCreamType.Strawberry:
                    return new Strawberry_Icecream();
                case IceCreamType.Chocolate:
                    return new Chocolate_Icecream();
                case IceCreamType.Vanilla:
                    return new Vanilla_Icecream();
                default:
                    return null;
            }
        }
    }
}
