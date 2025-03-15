// See https://aka.ms/new-console-template for more information
using System;
class HaloGeneric
{
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric.SapaUser("Faiz");
    }
}
