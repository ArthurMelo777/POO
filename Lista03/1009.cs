using System;

class Lista03 {
    public static void Main () {
        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine()), vendas = double.Parse(Console.ReadLine());
        
        double total = salario + vendas * 0.15;
        
        Console.WriteLine($"TOTAL = R$ {total:0.00}");
    }