using System;
using System.Text;

public class Solution {
    public string solution(string my_string, string alp) {
        StringBuilder answer = new StringBuilder();
        
        char targetChar = alp[0];
        
        foreach (char c in my_string)
        {
            // 문자열을 계속 붙일 때 성능상 StringBuilder가 더 좋음 (메모리 여유분을 처음부터 가지고 있기 때문)
            answer.Append(c == targetChar ? char.ToUpper(c) : c);
        }

      // 한 코드로 끝낼 수 있었던 문제
      // return my_string.Replace(alp, alp.ToUpper());
      return answer.ToString();
    }
}
