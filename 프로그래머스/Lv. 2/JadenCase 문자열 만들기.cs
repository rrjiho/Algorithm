public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] chars = s.ToLower().ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
        answer += chars[0];
        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == ' ' && i + 1 < chars.Length)
            {
                chars[i + 1] = char.ToUpper(chars[i + 1]);
            }
            answer += chars[i];
        }     
        return answer;
    }
}

/*
  StringBuilder answer = new StringBuilder();
  char[] chars = s.ToLower().ToCharArray();
  for (int i = 0; i < chars.Length; i++)
  {
      answer.Append(i == 0 || answer[i - 1] == ' ' ? char.ToUpper(chars[i]) : chars[i]);
  }

  return answer.ToString();
*/
