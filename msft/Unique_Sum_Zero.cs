/*

Given an integer n, return any array containing n unique integers such that they add up to 0.

 

Example 1:

Input: n = 5
Output: [-7,-1,1,3,4]
Explanation: These arrays also are accepted [-5,-1,1,2,3] , [-3,-1,2,-2,4].
Example 2:

Input: n = 3
Output: [-1,0,1]
Example 3:

Input: n = 1
Output: [0]
 

Constraints:

1 <= n <= 1000
*/
public class Solution {
    public int[] SumZero(int n) {
        int [] num = new int[n];
        int x = -10;
        int y = -6;
        int sum=0;
        var rand = new Random();
        for(int i=0; i<n-1; i++)
        {
            num[i]= rand.Next(x,y);
            sum += num[i];
            x = x + 5;
            y = y + 6;
            
            
        }
        Console.Write(sum);
        if(sum < 0){
        num[n-1] += sum;
        }
        if(sum >0){
            num[n-1] -=sum;
        }
        Console.Write(num);
        
        return num;
    }

}
