using System;

class Lista06 {
    public static void Main () {
        int n = int.Parse(Console.ReadLine());
        Console.Write("0 1");
        int ant = 0, atu = 1, suc;
        for (int i=2; i<n; i++) {
            suc = ant+atu;
            Console.Write($" {suc}");
            ant = atu; atu = suc;
        }
    }
}