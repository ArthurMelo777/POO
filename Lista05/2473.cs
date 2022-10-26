using System;

class Lista05 {
    public static void Main () {
        int[] aposta = Console.ReadLine().Split().Select(int.Parse).ToArray(), sorteio = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int acertos = 0;

        for (int i = 0; i < 6; i++) {
            for (int j = 0; j < 6; j++) {
                if (aposta[i] == sorteio[j]) acertos++;
            }
        }

        if (acertos < 3) Console.WriteLine("azar");
        else if (acertos == 3) Console.WriteLine("terno");
        else if (acertos == 4) Console.WriteLine("quadra");
        else if (acertos == 5) Console.WriteLine("quina");
        else if (acertos == 6) Console.WriteLine("sena");
    }
}