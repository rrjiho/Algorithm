using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] strings = s.Split(' ');

        int[] arr = new int[strings.Length];
        for (int i = 0; i < strings.Length; i++)
        {
            arr[i] = int.Parse(strings[i]);
        }
        Array.Sort(arr);

        answer = arr[0] + " " + arr[strings.Length - 1];
        
        return answer;
    }
}

/* LINQ 사용법 익히기
    string answer = "";
    int[] arr = s.Split(' ').Select(int.Parse).ToArray();
    answer = arr.Min().ToString() + " " + arr.Max().ToString();
*/
