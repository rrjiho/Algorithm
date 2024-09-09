using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        foreach(int arr in array)
        {
            if(arr == n)
                answer += 1;
        }

        // LINQ 람다 식 사용 가능
        //int answer = array.Count(x => x == n);
      
        return answer;
    }
}
