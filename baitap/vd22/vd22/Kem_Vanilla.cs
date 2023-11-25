using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd22
{
    public class Kem_Vanilla : IKem
    {
        public string TenKem()
        {
            return "Cool";
        }
        public string TenHangKem()
        {
            return "LongHai";
        }
        public int SoLuong()
        {
            return 30000;
        }
        public string DonGia1Chiec()
        {
            return "3.50 USD";
        }
    }
}
