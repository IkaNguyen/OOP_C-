using Factory1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        var kem = new TaoFac();
        IFactory strawberry = kem.Create(DaFactory.IceCreamType.Strawberry);
        Console.WriteLine(strawberry.Xuat());
        IFactory chocolate = kem.Create(DaFactory.IceCreamType.Chocolate);
        Console.WriteLine(chocolate.Xuat());
        IFactory vanilla = kem.Create(DaFactory.IceCreamType.Vanilla);
        Console.WriteLine(vanilla.Xuat());

        Console.ReadKey();
    }
}