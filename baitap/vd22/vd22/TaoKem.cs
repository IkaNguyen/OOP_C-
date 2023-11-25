using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd22
{
    class TaoKem : KemFactory
    {
        public override IKem Create(KemItem item)
        {
            switch (item) 
            {
                case KemItem.KemDau:
                    return new Kem_Dau();
                case KemItem.KemSocola:
                    return new Kem_Socola();
                case KemItem.KemVanilla:
                    return new Kem_Vanilla();
                default:
                    return null;
            }
        }
    }
}
