public class Solution {
    public bool IsGood(int[] nums) {
        if (nums.Length < 2) {
            return false;
        }

        Array.Sort(nums);

        int n = nums.Length - 1;
        for (int i = 0; i < n - 1; i++) {
            if (nums[i] != i + 1) {
                return false;
            }
        }

        return nums[n - 1] == n && nums[n] == n;
    }
}

// public class Solution {
//     public bool IsGood(int[] nums) {
//         int n = nums.Max();

//         if (nums.Length != n + 1) {
//             return false;
//         }

//         int[] count = new int[n + 1];

//         foreach (int num in nums) {
//             if (num < 1 || num > n) {
//                 return false;
//             }

//             count[num]++;
//         }

//         for (int i = 1; i < n; i++) {
//             if (count[i] != 1) {
//                 return false;
//             }
//         }

//         return count[n] == 2;
//     }
// }