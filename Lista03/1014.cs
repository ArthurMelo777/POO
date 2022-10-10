using System;

class Lista03 {
    public static void Main () {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine($"{x/y:0.000} km/l");
    }
}