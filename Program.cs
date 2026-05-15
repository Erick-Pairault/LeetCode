using System;

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        Console.WriteLine(sol.IsPowerOfFour(64)); // true
        Console.WriteLine(sol.IsPowerOfFour(16)); // true
        Console.WriteLine(sol.IsPowerOfFour(5));  // false  
    }
}