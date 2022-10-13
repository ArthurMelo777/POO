using System;

class Lista03 {
    public static void Main () {
        Console.WriteLine("Digite a base e a altura do retângulo: ");
        double b = double.Parse(Console.ReadLine()), h = double.Parse(Console.ReadLine());
        Console.WriteLine($"Área = {b*h:0.00} - Perímetro = {b*2+h*2:0.00} - Diagonal = {Math.Sqrt(Math.Pow(b,2)+Math.Pow(h,2)):0.00}");
    }
}