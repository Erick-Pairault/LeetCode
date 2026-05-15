namespace IsPowerOfFourRecursive;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n == 1)
        {
            return true;
        }
        else if (n % 4 != 0 || n == 0)
        {
            return false;
        }
        else
            return IsPowerOfFour(n / 4);
    }
}