using System;

class Program
{
    static void Main(string[] args)
    {
        byte b = 10;
        short s = 200;
        int i = 5000;
        long l = 100000;
        float f = 12.5f;
        double d = 123.456;
        decimal dec = 1234.5678m;
        char c = 'A';
        bool isTrue = true;

        string intToString = i.ToString();
        double stringToDouble = Convert.ToDouble("3.14");

        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {s}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"long: {l}");
        Console.WriteLine($"float: {f}");
        Console.WriteLine($"double: {d}");
        Console.WriteLine($"decimal: {dec}");
        Console.WriteLine($"char: {c}");
        Console.WriteLine($"bool: {isTrue}");
        Console.WriteLine($"intToString: {intToString}");
        Console.WriteLine($"stringToDouble: {stringToDouble}");
    }
}
