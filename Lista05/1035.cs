using System;
using System.Linq;

class Lista05 {
    public static void Main () {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = nums[0], b = nums[1], c = nums[2], d = nums[3];
        if (b>c && d>a && (c+d)>(a+b) && c>0 && d>0 && a%2==0) {
            Console.WriteLine("Valores aceitos");
        }
        else {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}