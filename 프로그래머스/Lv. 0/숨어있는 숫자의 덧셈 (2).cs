using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        char a = 'a';
        char z = 'z';
        
        string str = my_string.ToLower();
        
        for (int i = 0; i < str.Length; i++)
        {
            if(str[i] >= a && str[i] <= z)
                str = str.Replace(str[i], ' ');
        }
        
        string[] arr = str.Split(" ");
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != "")
                answer += Int32.Parse(arr[i]);
        }
        // 문자열 기능 Replace, IsNUmber, IsDigit 등을 사용하여 여러 방법으로 해결 가능
        return answer;
    }
}
