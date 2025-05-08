using System;

class Program
{
    static void Main()
    {
        Console.Write("یک عدد وارد کنید: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("عدد زوج است.");
        else
            Console.WriteLine("عدد فرد است.");
    }
}
