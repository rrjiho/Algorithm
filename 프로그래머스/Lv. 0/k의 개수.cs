using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        
        for (int l = i; l <= j; l++)
        { 
            foreach(char c in l.ToString())
                if(c == (char)(k + 48))
                    answer++;
        }
        // 결국 이런 문제들은 문자열로 하나씩 비교하거나 정수로 / % 이용해서 하나씩 비교하거나
        return answer;
    }
}
