namespace IsPowerOfFourLoop;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        for(int i = 1; i > 0; i *= 4)
        {
            if (i == n)
            {
                return true;
            }
        }
        return false;
    }
}