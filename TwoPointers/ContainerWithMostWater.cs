// Problem: https://leetcode.com/problems/container-with-most-water/description/?envType=problem-list-v2&envId=two-pointers
// Language: C#

public class Solution {
    public int MaxArea(int[] height) {
        int start = 0, end = height.Length - 1;
        int area = 0;

        while(start != end){
            int min = Math.Min(height[start], height[end]);
            int result = (end - start) * min;
            area = Math.Max(area, result);
            if(height[start] < height[end]){
                start++;
            }else{
                end--;
            }
        }
        return area;
    }
}