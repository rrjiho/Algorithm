using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            string s = array[i].ToString();
            foreach (char c in s)
            {
                if (c == '7')
                    answer++;
            }
        }
        // %10 == 7 이용 가능
        return answer;
    }
}
