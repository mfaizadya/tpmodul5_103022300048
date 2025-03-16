// See https://aka.ms/new-console-template for more information
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
        DataGeneric<string> data = new DataGeneric<string>("103022300048");
        data.PrintData();
    }
}
