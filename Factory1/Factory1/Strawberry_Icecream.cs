using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory1
{
    class Strawberry_Icecream : IFactory
    {
        public string Xuat() 
        {
            return "This is strawberry ice cream.";
        }
    }
}
