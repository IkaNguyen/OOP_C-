using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd22
{
    public abstract class KemFactory
    {
        public abstract IKem Create(KemItem item);
    }
}
