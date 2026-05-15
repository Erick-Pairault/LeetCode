using System;

class Program
{
    static void Main(string[] args)
    {
        IsPowerOfFourLoop.Solution sol = new IsPowerOfFourLoop.Solution();
        IsPowerOfFourRecursive.Solution sol2 = new IsPowerOfFourRecursive.Solution();

        Console.WriteLine("Testing IsPowerOfFourLoop.Solution");
        Console.WriteLine(sol.IsPowerOfFour(64)); // true
        Console.WriteLine(sol.IsPowerOfFour(16)); // true
        Console.WriteLine(sol.IsPowerOfFour(5));  // false  
    
        Console.WriteLine("Testing IsPowerOfFourRecursive.Solution");
        Console.WriteLine(sol2.IsPowerOfFour(64)); // true
        Console.WriteLine(sol2.IsPowerOfFour(16)); // true
        Console.WriteLine(sol2.IsPowerOfFour(5));  // false
}
}