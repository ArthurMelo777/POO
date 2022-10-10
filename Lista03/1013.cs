using System;
using System.Linq;

class Lista03 {
    public static void Main () {
        int maiorAB, maior;
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        maiorAB = (nums[0] + nums[1] + Math.Abs(nums[0] - nums[1]))/2;
        maior = (maiorAB + nums[2] + Math.Abs(maiorAB - nums[2]))/2;
        Console.WriteLine($"{maior} eh o maior");
    }
}