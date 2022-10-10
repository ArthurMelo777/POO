using System;
using System.Linq;

class Lista03 {
    public static void Main () {
        int valor = int.Parse(Console.ReadLine()), qtd;
        
        Console.WriteLine(valor);

        qtd = valor / 100;
        valor = valor - qtd * 100;
        Console.WriteLine($"{qtd} nota(s) de R$ 100,00");
        
        qtd = valor / 50;
        valor = valor - qtd * 50;
        Console.WriteLine($"{qtd} nota(s) de R$ 50,00");
        
        qtd = valor / 20;
        valor = valor - qtd * 20;
        Console.WriteLine($"{qtd} nota(s) de R$ 20,00");
        
        qtd = valor / 10;
        valor = valor - qtd * 10;
        Console.WriteLine($"{qtd} nota(s) de R$ 10,00");
        
        qtd = valor / 5;
        valor = valor - qtd * 5;
        Console.WriteLine($"{qtd} nota(s) de R$ 5,00");
        
        qtd = valor / 2;
        valor = valor - qtd * 2;
        Console.WriteLine($"{qtd} nota(s) de R$ 2,00");
        
        Console.WriteLine($"{valor} nota(s) de R$ 1,00");
    }
}