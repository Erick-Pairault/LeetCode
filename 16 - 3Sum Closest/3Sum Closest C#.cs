public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int closest = nums[0] + nums[1] + nums[2];
        for(int i = 0; i < nums.Length - 2; i++){
            for(int j = i + 1; j < nums.Length -1; j++){
                for(int k = j + 1; k < nums.Length; k++){
                    if(closest == target){
                        return closest;
                    } else if (Math.Abs(target - (nums[i] + nums[j] + nums[k])) < Math.Abs(target - closest)){
                        closest = nums[i] + nums[j] + nums[k];
                    }
                }
            }
        }
        return closest;
    }
}