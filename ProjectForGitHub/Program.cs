internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5;
        int b = 6;
        int c = 7;

        int toplam = a + b + c;
        string _msg = $"Toplam : {toplam}";
        Console.WriteLine(_msg);
        
        Console.WriteLine("");

        int cıkarma = (a + b) - c;
        string _msg1 = $"Çıkarma : {cıkarma}";
        Console.WriteLine(_msg1);
        
        Console.WriteLine("");

        int carpma = a * b * c;
        string _msg2 = $"Çarpma : {carpma}";
        Console.WriteLine(_msg2);
    }
}