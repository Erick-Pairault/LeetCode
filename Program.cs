using System;

class Program
{
    static void Main(string[] args)
    {
        // IsPowerOfFourLoop.Solution sol = new IsPowerOfFourLoop.Solution();
        // IsPowerOfFourRecursive.Solution sol2 = new IsPowerOfFourRecursive.Solution();

        // Console.WriteLine("Testing IsPowerOfFourLoop.Solution");
        // Console.WriteLine(sol.IsPowerOfFour(64)); // true
        // Console.WriteLine(sol.IsPowerOfFour(16)); // true
        // Console.WriteLine(sol.IsPowerOfFour(5));  // false  
    
        // Console.WriteLine("Testing IsPowerOfFourRecursive.Solution");
        // Console.WriteLine(sol2.IsPowerOfFour(64)); // true
        // Console.WriteLine(sol2.IsPowerOfFour(16)); // true
        // Console.WriteLine(sol2.IsPowerOfFour(5));  // false

        FindMinInRotatedSortedArr.Solution sol3 = new FindMinInRotatedSortedArr.Solution();

        int[] test1 = { 3, 4, 5, 1, 2 };
        int[] test2 = { 4, 5, 6, 7, 0, 1, 2 };
        int[] test3 = { 11, 13, 15, 17 };
        int[] test4 = { 2, 1 };
        int[] test5 = { 5, 1, 2, 3, 4 };

        Console.WriteLine(sol3.FindMin(test1)); // 1
        Console.WriteLine(sol3.FindMin(test2)); // 0
        Console.WriteLine(sol3.FindMin(test3)); // 11
        Console.WriteLine(sol3.FindMin(test4)); // 1
        Console.WriteLine(sol3.FindMin(test5)); // 1
    }
}