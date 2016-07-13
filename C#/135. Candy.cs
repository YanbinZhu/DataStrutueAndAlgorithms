/*135. Candy
There are N children standing in a line. Each child is assigned a rating value.

You are giving candies to these children subjected to the following requirements:

Each child must have at least one candy.
Children with a higher rating get more candies than their neighbors.
What is the minimum candies you must give?*/

    
       
public class Solution {
    public int Candy(int[] ratings) {

        var counterArray=new int[ratings.Length];

        for(int i=0;i<ratings.Length; i++)
        {
            counterArray[i]=1;
        }

        for(int i=1;i<ratings.Length; i++)
        {
            if(ratings[i]>ratings[i-1])
            {
                counterArray[i]=counterArray[i-1]+1;
            }
        }

        for(int i=ratings.Length-1;i>0;i--)
        {
            if(ratings[i-1]>ratings[i])
            {
                   counterArray[i-1]=Math.Max(counterArray[i-1],counterArray[i]+1);
            }
        }

        var result=0;

        for(int i=0;i<ratings.Length; i++)
        {
            result+=counterArray[i];
        }

        return result;

    }
}