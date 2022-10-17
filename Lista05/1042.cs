using System;
using System.Linq;

class Lista05 {
    public static void Main () {
        int[] vetor = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] vetorOg = {vetor[0], vetor[1], vetor[2]};
        Array.Sort(vetor);
        Console.WriteLine($"{vetor[0]}\n{vetor[1]}\n{vetor[2]}\n");
        Console.WriteLine($"{vetorOg[0]}\n{vetorOg[1]}\n{vetorOg[2]}");
    }
}