using System;
using System.Linq;

class Lista05 {
    public static void Main () {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        if (nums[0]>nums[1] && nums[1]>nums[2] && nums[2]>nums[3] && nums[3]>nums[4]) {
            Console.WriteLine("D");
        }
        else if (nums[0]<nums[1] && nums[1]<nums[2] && nums[2]<nums[3] && nums[3]<nums[4]) {
            Console.WriteLine("C");
        }
        else {
            Console.WriteLine("N");
        }
    }
}