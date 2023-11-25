using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace vd22
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new TaoKem();
            IKem kemdau = factory.Create(KemItem.KemDau);
            Console.WriteLine("Ten kem: " + kemdau.TenKem());
            Console.WriteLine("Ten hang kem: " + kemdau.TenHangKem());
            Console.WriteLine("So luong: " + kemdau.SoLuong());
            Console.WriteLine("Don gia 1 chiec: " + kemdau.DonGia1Chiec());
            Console.WriteLine("==================================");

            IKem kemsocola = factory.Create(KemItem.KemSocola);
            Console.WriteLine("Ten kem: " + kemsocola.TenKem());
            Console.WriteLine("Ten hang kem: " + kemsocola.TenHangKem());
            Console.WriteLine("So luong: " + kemsocola.SoLuong());
            Console.WriteLine("Don gia 1 chiec: " + kemsocola.DonGia1Chiec());
            Console.WriteLine("==================================");

            IKem kemvani = factory.Create(KemItem.KemVanilla);
            Console.WriteLine("Ten kem: " + kemvani.TenKem());
            Console.WriteLine("Ten hang kem: " + kemvani.TenHangKem());
            Console.WriteLine("So luong: " + kemvani.SoLuong());
            Console.WriteLine("Don gia 1 chiec: " + kemvani.DonGia1Chiec());
            Console.WriteLine("==================================");

            Console.ReadKey();
        }
    }
}