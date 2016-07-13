/*134. Gas Station
    
    There are N gas stations along a circular route, where the amount of gas at station i is gas[i].

You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from station i to its next station (i+1). You begin the journey with an empty tank at one of the gas stations.

Return the starting gas station's index if you can travel around the circuit once, otherwise return -1.

Note:
The solution is guaranteed to be unique.*/


public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        int remAmount=0,int sumGas=0,int sumCost=0,int startPostion=0;
        
        for(int i=0; i<gas.Length; i++)
        {
            sumGas += gas[i];
            sumCost += cost[i];
            
            remAmount += gas[i] - cost[i];
            
            if(remAmount < 0)
            {
                remAmount=0;
                startPostion=i+1;
            }
        }
        
        return sumGas < sumCost ? -1 : startPostion ;
    }
}