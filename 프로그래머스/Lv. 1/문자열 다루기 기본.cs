public class Solution {
    public bool solution(string s) {
        bool answer = true;
        
        char _zero = '0';
        char _nine = '9';

        if (s.Length == 4 || s.Length == 6)
        {
            foreach (char c in s)
            {
                if (c < _zero || c > _nine)
                {
                    answer = false;
                    break;
                }       
            }
        }
        else
            answer = false;
        
        
        return answer;
    }
}
