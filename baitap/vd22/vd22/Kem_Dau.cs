using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd22
{
    public class Kem_Dau : IKem
    {
        public string TenKem() 
        {
            return "Lilya Icecream";
        }
        public string TenHangKem()
        {
            return "LongHai";
        }
        public int SoLuong()
        {
            return 20000;
        }
        public string DonGia1Chiec()
        {
            return "2.50 USD";
        }
    }
}
