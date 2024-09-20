public class Solution {
    public string solution(string s) {
        string answer = "";
        int idx = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                answer += s[i];
                idx = 0;
            }
            else if (idx % 2 == 0)
            {
                answer += char.ToUpper(s[i]); 
                idx++;
            }
            else if (idx % 2 != 0)
            {
                answer += char.ToLower(s[i]);
                idx++;
            }
        }
      /*
      answer += num % 2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();
      num = s[i] == ' '? 0 : num + 1;
      위 풀이를 간단하게 깔끔하게 작성할 수 있음을 보여주는 예시 (로직 원리를 이해하면 가능)
      */
        
        return answer;
    }
}
