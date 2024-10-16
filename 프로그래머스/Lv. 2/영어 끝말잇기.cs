using System;
using System.Collections.Generic;
class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = {0, 0};
        
        List<string> str = new List<string>();
        int cnt = 0;
        for(int i = 1; i < words.Length; i++)
        {            
            str.Add(words[i - 1]);
            
            if((words[i - 1])[words[i - 1].Length - 1] != (words[i])[0] || (str.Contains(words[i])))
            {
                answer[0] = i % n + 1;
                answer[1] = i / n + 1;
                break;
            }
        }
        
        
        return answer;
    } // 설명에 적힌 그대로 로직을 작성하면 됨
      // 단어 끝과 다음 단어 시작이 같은지, 중복된 단어를 포함하는지 확인하고 return
}
