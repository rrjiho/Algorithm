public class Solution {
    public string solution(string s) {
        string answer = "";
        int len = s.Length;
        int i = len / 2;
        
        if (len % 2 == 0)
        {    
            answer += s[i - 1];
            answer += s[i];
        }
        else
            answer += s[i];
      // substring 사용하면 깔끔할 수 있음
      /*int i = s.Length / 2;
            if (s.Length % 2 == 0)
                answer = s.Substring(i - 1, 2);            
            else
                answer = s.Substring(i, 1);*/
        return answer;
    }
}
