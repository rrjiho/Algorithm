public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        int len = phone_number.Length;
        
        for (int i = 0; i < len; i++)
        {
            if (i < len - 4)
                answer += "*";
            else
                answer += phone_number[i];
        }
        
        return answer;
    }
}
