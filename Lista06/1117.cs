using System;

class Lista06 {
    public static void Main () {
        int notas = 0;
        double media = 0;
        while (notas < 2) {
            double nota = double.Parse(Console.ReadLine());
            if (validar(nota)) {
                media += nota;
                notas++;
            }
        }
        Console.WriteLine($"media = {media/2:0.00}");
    }
}