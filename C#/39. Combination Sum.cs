/*39. Combination Sum
    Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.

The same repeated number may be chosen from C unlimited number of times.

Note:
All numbers (including target) will be positive integers.
The solution set must not contain duplicate combinations.
For example, given candidate set [2, 3, 6, 7] and target 7, 
A solution set is: 
[
  [7],
  [2, 2, 3]
]*/


public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> combination = new List<int>();
        Array.Sort(candidates);
        CombinationSum(result, candidates, combination, target, 0);
        return result;
    }

    private void CombinationSum(IList<IList<int>> result, int[] candidates, IList<int> combination, int target, int start)
    {
        if (target == 0)
        {
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = start; i != candidates.Length && target >= candidates[i]; ++i)
        {
            combination.Add(candidates[i]);
            CombinationSum(result, candidates, combination, target - candidates[i], i);
            combination.Remove(combination.Last());
        }
    }
}