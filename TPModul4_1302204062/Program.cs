using System;

namespace TPModul4_1302204062
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataGeneric<int> data1 = new DataGeneric<int>(1302204062);
            data1.PrintData();
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
