public class Solution {
    public int SumOfDigits(int n) {
        int sum = 0;
        while(n > 0) {
            sum += (n % 10);
            n /= 10;
        }
        return sum;
    }

    public int MinElement(int[] nums) {
        nums[0] = SumOfDigits(nums[0]);
        int min = nums[0];
        for(int i = 1; i < nums.Length; i++) {
            nums[i] = SumOfDigits(nums[i]);
            if(nums[i] < min) {
                min = nums[i];
            }
        }
        return min;
    }
}