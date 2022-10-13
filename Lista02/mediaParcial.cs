using System;

class Lista03 {
    public static void Main () {
        Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do segundo bimestre da disciplina: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Média parcial = {(n1*2+n2*3)/5}");
    }
}