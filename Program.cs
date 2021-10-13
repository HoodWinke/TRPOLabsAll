using System;

namespace TrpoLaba1
{
    class Program
    {
        static void Main(string[] args)
        {
            A1 = new A();
            B2 = new B(A1);
            B3 = new B(B2);
            B4 = new B(B3);
            C5 = new C5(A1, B4);
        }
    }
}
