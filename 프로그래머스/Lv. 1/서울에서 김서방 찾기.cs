public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int x = 0;
        
        foreach (string s in seoul)
        {
            if (s == "Kim")
                break;
            
            x++;
        }
        
        answer = $"김서방은 {x}에 있다";
        
        return answer;
    }
}
