using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int, int> countDict = new Dictionary<int, int>();
        
        foreach (int s in tangerine)
        {
            if (countDict.ContainsKey(s))
                countDict[s]++;
            else
                countDict[s] = 1;
        }
        
        List<int> countList = countDict
            .Select(n => n.Value).OrderByDescending(n => n).ToList();
        
        foreach (int i in countList)
        {
            k = k - i;
            answer++;
            if (k <= 0)
                break;
        }
        
        return answer;
    } // 나만 Dict 사용한 줄 알았으나 Dict을 활용한 문제였음.
      // 중복 개수가 많은 순서로 담아서 k개와 비교하면 됨.
}
