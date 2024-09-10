using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;

        // 간단하게도 가능하지만
        answer = str1.Contains(str2) ? 1 : 2;

        // 라이브러리 사용하지 않고 풀었을 시
        /*for (int i = 0; i <= str1.Length - str2.Length; i++) {
        마지막 비교 가능한 사이즈 만큼 비교
          bool found = true;
          for (int j = 0; j < str2.Length; j++) 
          {
              if (str1[i + j] != str2[j])
              한 글자가 맞으면 끝까지 비교해서 만약 하나라도 다르면 false
              {
                  found = false;
                  break;
              }
          }
          if (found)
          다 맞으면 1
              answer = 1;        
      }
      answer =2; */
  }
        return answer;
    }
}
