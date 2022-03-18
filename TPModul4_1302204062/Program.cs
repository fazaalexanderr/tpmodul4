using System;

namespace TPModul4_1302204062
{
    class Program
    {
        public static void Main(string[] args)
        {
            HaloGeneric.SapaUser<string>("Faza");

            DataGeneric<int> data1 = new DataGeneric<int>(1302204062);
            data1.PrintData();
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }

    public class DataGeneric<T>
    {
        private T Data;

        public DataGeneric(T Data)
        {
            this.Data = Data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.Data);
        }
    }
}
