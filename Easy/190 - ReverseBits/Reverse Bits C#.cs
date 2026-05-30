public class Solution
{
    public int ReverseBits(int n)
    {
        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            result <<= 1;      // Make room for next bit
            result |= (n & 1); // Copy rightmost bit from n
            n >>= 1;           // Move to next bit
        }

        return result;
    }
}