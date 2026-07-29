public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int n = nums.Length;
int first = int.MaxValue - 1, second = int.MaxValue;
bool triplets = false;
for (int i = 0; i < n; i++)
{
    if (nums[i] < first)
        first = nums[i];
    else if (nums[i] > first && nums[i] < second)
        second = nums[i];
    else if (nums[i] > second)
        return true;
}
       return false; 
    }
}