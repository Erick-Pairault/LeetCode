public class Solution {
    public int[] PlusOne(int[] digits) {
        // Start from the last digit
        for (int i = digits.Length - 1; i >= 0; i--) {
            
            // If digit is less than 9, just add 1 and return
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }

            // If digit is 9, it becomes 0 and carry continues
            digits[i] = 0;
        }

        // If all digits were 9, create new array
        int[] result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }
}