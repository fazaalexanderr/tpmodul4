using System;

namespace TPModul4_1302204062
{
    class Program
    {
        public static void Main(string[] args)
        {
            HaloGeneric.SapaUser<string>("Faza");
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
}
