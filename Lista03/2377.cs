using System;
using System.Linq;

class Lista03 {
    public static void Main () {
        int[] ld = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] kp = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Console.WriteLine($"{ld[0]/ld[1]*kp[1] + ld[0]*kp[0]}");
    }
}