// Problem: https://leetcode.com/problems/remove-duplicates-from-sorted-array/?envType=problem-list-v2&envId=two-pointers 
// Language: C#

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int uniqueNumbers = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] != nums[uniqueNumbers]){
                uniqueNumbers++;
                nums[uniqueNumbers] = nums[i];
            }
        }
        return uniqueNumbers + 1;
    }
}