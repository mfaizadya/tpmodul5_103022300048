// See https://aka.ms/new-console-template for more information

using System;
class HaloGeneric
{
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpang adalah: {data}");

        }
    }


    class Program
    {
        static void Main()
        {

            HaloGeneric.SapaUser("Faiz");

            DataGeneric<string> data = new DataGeneric<string>("103022300048");
            data.PrintData();

        }
    }
}
