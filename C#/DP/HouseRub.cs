/*House Robber
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.*/

public int Rob(int[] nums) {

    var length = nums.Length;

    if(length==0)
    {
        return 0;
    }

      var numsNew=new int[length + 1];

      numsNew[0]=0;

      for(int i=nums.Length-1;i>-1;i--)
      {
         numsNew[i+1]=nums[i];
      }

    var dp = new int[length + 1];

    dp[0] = 0;
    dp[1] = numsNew[1];
    var maxRub = numsNew[1];
    var contain = true;

    for(int i = 2; i < length + 1; i++)
    {
        if(!contain)
        {
            dp[i] = dp[i-1] + numsNew[i];

            contain = true;
        }
        else
        {

            if(dp[i - 2] + numsNew[i] > dp[i-1])
            {
                dp[i] = dp[i-2] + numsNew[i];
                contain = true;
            }
            else
            {
                dp[i] = dp[i-1];
                contain = false;
            }

        }

        maxRub = Math.Max(dp[i],maxRub);
    }

    return maxRub;
}
