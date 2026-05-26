public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];

            if(map.ContainsKey(needed))
            {
                return new int[] { map[needed], i };
            }

            map[nums[i]] = i;
        }

        return new int[0];
    }
}

// Solution Ver. 1

// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         int[] indices = new int[2];
//         for(int i = 0; i < nums.Length; i++)
//         {
//             for(int j = i + 1; j < nums.Length; j++)
//             {
//                 if(nums[i] + nums[j] == target)
//                 {
//                     indices[0] = i;
//                     indices [1] = j;
//                     return indices;
//                 }
//             }
//         }
//         return indices;
//     }
// }