using System;
using System.Text;

public class Solution {
    public string solution(int[] numLog) 
    {
        var sb = new StringBuilder();
        int n = numLog[0];
        for(int i = 1; i < numLog.Length; ++i)
        {
            int next = numLog[i];

            if(n + 1 == next)       sb.Append("w");
            else if(n - 1 == next)  sb.Append("s");
            else if(n + 10 == next) sb.Append("d");
            else if(n - 10 == next) sb.Append("a");

            n = next;
        }

        return sb.ToString();
    }
}
// 그냥 answer += '문자' 이 방법을 사용하면 처리 시간이 매우 지연된다.
// StringBuilder 사용 시 2ms 이내로 모은 케이스 통과
// 조건에 numLog 길이 <= 100000 이기 때문
