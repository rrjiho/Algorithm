using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer;

        if (n % 2 == 0)
            answer = new int[n / 2];
        else
            answer = new int[n / 2 + 1];

        for(int i = 0; i < n + 1; i++)
        {
            if (i % 2 != 0)
                answer[i / 2] = i;
        }

        // int[] answer = Enumerable.Range(1, n).Where(x => x % 2 == 1).ToArray();

        return answer;
    }
}
