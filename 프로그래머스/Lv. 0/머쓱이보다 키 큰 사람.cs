using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        
        foreach(int arr in array)
        {
            if(arr > height)
                answer++;
        }

        // LINQ 사용
        // answer = array.Count(x => x > height);
      
        return answer;
    }
}
