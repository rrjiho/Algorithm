using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string ab = a.ToString() + b.ToString();
        string ba = b.ToString() + a.ToString();
        
        int AB = Int32.Parse(ab);
        int BA = Int32.Parse(ba);
        
        answer = AB >= BA ? AB : BA;
        
        return answer;
    }
}
