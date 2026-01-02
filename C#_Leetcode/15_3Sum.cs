/*
==========================================================
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

 
Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.
Example 2:

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.
Example 3:

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
 

Constraints:

3 <= nums.length <= 3000
-105 <= nums[i] <= 105

==========================================================
*/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        //Sort the array
        Array.Sort(nums);
        var len = nums.Length;
        IList<IList<int>> result = new List<IList<int>>();

        // 3 pointer approach.
        for(int  i =0; i<len-2; i++ )
        {
            // push i to avoid duplicates.
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int j = i+1;   // next valid item from i
            int k = len-1; // start from last

            while(j<k)
            {
                //calculate sum.
                var total = nums[i]+nums[j]+nums[k];

                // if 0 add to list.
                if(total == 0){
                    result.Add(new List<int>(){ nums[i],nums[j],nums[k] });
                    // since we found a match we move j and k to check if any other combination is possible with current i value.
                    j++;
                    while( j < k && nums[j-1] == nums[j])
                        j++;

                    k--;
                    while ( j < k && nums[k] == nums[k+1])
                        k--;
                }
                // if < then move j
                else if ( total < 0 )
                    j++;

                // if > then move k
                else if ( total > 0)
                    k--;
                
            }
        }
        return result;
    }   
}