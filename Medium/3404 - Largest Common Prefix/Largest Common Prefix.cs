public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        HashSet<int> prefixes = new HashSet<int>();

        // Add each prefix combo from array 1 into HashSet which will also ignore duplicates
        foreach(int num in arr1) {
            int x = num;
            while(x > 0) {
                prefixes.Add(x);
                x /= 10;
            }            
        }

        int max = 0;
        // Check each prefix of every num in arr2 to our HashSet
        foreach(int num in arr2) {
            int x = num;
            while(x > 0) {
                if(prefixes.Contains(x)) {
                    max = Math.Max(max, x.ToString().Length);
                    break;
                }
                x /= 10;
            }
        }

        return max;
    }
}

// Solution Ver 1
// public class Solution {
//     public int LongestCommonPrefix(int[] arr1, int[] arr2) {
//         int max = 0;

//         for (int i = 0; i < arr1.Length; i++) {
//             for (int j = 0; j < arr2.Length; j++) {

//                 string num1 = arr1[i].ToString();
//                 string num2 = arr2[j].ToString();

//                 int digit = 0;

//                 while (
//                     digit < num1.Length &&
//                     digit < num2.Length &&
//                     num1[digit] == num2[digit]
//                 ) {
//                     digit++;
//                 }

//                 if (digit > max) {
//                     max = digit;
//                 }
//             }
//         }

//         return max;
//     }
// }