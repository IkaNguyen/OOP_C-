using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd22
{
    public class Kem_Socola : IKem
    {
        public string TenKem()
        {
            return "Aloha!";
        }
        public string TenHangKem()
        {
            return "LongHai";
        }
        public int SoLuong()
        {
            return 15000;
        }
        public string DonGia1Chiec()
        {
            return "2.25 USD";
        }
    }
}
