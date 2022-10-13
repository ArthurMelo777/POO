using System;

class Lista03 {
    public static void Main () {
        string[] nums = Console.ReadLine().Split();
        double a = double.Parse(nums[0]), b = double.Parse(nums[1]), c = double.Parse(nums[2]);
        Console.WriteLine($"TRIANGULO: {a*c/2:0.000}");
        Console.WriteLine($"CIRCULO: {3.14159 * Math.Pow(c, 2):0.000}");
        Console.WriteLine($"TRAPEZIO: {(a+b)*c/2:0.000}");
        Console.WriteLine($"QUADRADO: {Math.Pow(b, 2):0.000}");
        Console.WriteLine($"RETANGULO: {a*b:0.000}");
    }
}