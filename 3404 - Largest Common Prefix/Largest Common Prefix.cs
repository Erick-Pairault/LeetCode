public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        int max = 0;

        for (int i = 0; i < arr1.Length; i++) {
            for (int j = 0; j < arr2.Length; j++) {

                string num1 = arr1[i].ToString();
                string num2 = arr2[j].ToString();

                int digit = 0;

                while (
                    digit < num1.Length &&
                    digit < num2.Length &&
                    num1[digit] == num2[digit]
                ) {
                    digit++;
                }

                if (digit > max) {
                    max = digit;
                }
            }
        }

        return max;
    }
}