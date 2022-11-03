using System;

class Lista06 {
    public static void Main () {
        string[] palavras = Console.ReadLine().ToUpper().Split(' ');
        bool tauto;
        while (palavras[0] != "*") {
            tauto = true;
            for (int i = 0; i<palavras.Length; i++) {
                if (i == palavras.Length-1) break;
                else {
                    if (palavras[i][0] != palavras[i+1][0]) {
                        tauto = false;
                    }
                }
            }
            
            if (tauto) Console.WriteLine("Y");
            else Console.WriteLine("N");
            palavras = Console.ReadLine().ToUpper().Split(' ');
        }
    }
}