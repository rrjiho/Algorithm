using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        int n = discount.Length;
        
        Dictionary<string, int> wantdict = new Dictionary<string, int>();
        for (int i = 0; i < want.Length; i++)
            wantdict[want[i]] = number[i];
        
        for (int i = 0; i <= n - 10; i++) // <= 해야 10까지 셀 수 있음
        {
            Dictionary<string, int> discountDict = new Dictionary<string, int>();
            
            for (int j = 0; j < 10; j++)
            {
                string product = discount[i + j];
                if (discountDict.ContainsKey(product))
                    discountDict[product]++;
                else
                    discountDict[product] = 1;
                    
            }
            
            if (IsMaching(wantdict, discountDict))
                answer++;
        }
        
        
        return answer;
    }
    
    public bool IsMaching(Dictionary<string, int> wantDict, Dictionary<string, int>discountDict)
    {
        foreach (var item in wantDict)
        {
            if(!discountDict.ContainsKey(item.Key) || discountDict[item.Key] < item.Value)
                return false;
        }
        
        return true;
    }
} // Dictionary 매번 생성에 대한 메모리 낭비? => 스코프가 작기 때문에 큰 문제는 없음
  // 만약 메모리를 더 효율적으로 사용해야 한다면 생성한 Dict을 재활용하는 방안
