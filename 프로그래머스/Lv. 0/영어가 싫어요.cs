using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string[] num = new string[]{"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        for(int i = 0; i < num.Length; i++)
        {
            numbers = numbers.Replace(num[i], i.ToString());
        }
        
        answer = long.Parse(numbers);
        
        return answer;
    }
}
