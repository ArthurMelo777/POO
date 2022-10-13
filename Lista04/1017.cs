using System;

class Lista03 {
    public static void Main () {
        int t = int.Parse(Console.ReadLine()), v = int.Parse(Console.ReadLine());
        Console.WriteLine($"{v*t/12.0:0.000}");
    }
}