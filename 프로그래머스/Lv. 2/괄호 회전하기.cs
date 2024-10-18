using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int len = s.Length;
        
        string doubleS = s + s; // 스왑해서 새로운 str 만드는 것보다 효율적임
        
        for (int i = 0; i < len; i++)
        {
            if (IsValid(doubleS.Substring(i, len))) 
                answer++; 
        }
        
        return answer;
    }
    
    public bool IsValid(string str)
    {
        Stack<char> stack = new Stack<char>();
        
        foreach (char ch in str)
        {
            if (ch == '(' || ch == '[' || ch == '{')
                stack.Push(ch);
            else
            {
                if (stack.Count == 0) return false; // 짝이 없는 닫는 괄호
                
                char top = stack.Pop();
                if(!IsMatching(top, ch)) return false; // 짝이 맞지 않는 경우
            }
        }
        return stack.Count == 0; // 스택이 비어 있으면 OK
    }
    
    public bool IsMatching(char open, char close)
    {
        return (open == '(' && close == ')') ||
            (open == '[' && close == ']') ||
            (open == '{' && close == '}');
    }
} // 이전 풀이의 실패로 stack queue 등 Containers 뿐만 아니라 메서드를 직접 작성해서 가독성을 높이는 것에 대한
// 필요성을 실감함
// 우선 문제를 해결하는 것도 중요하지만 누군에게 코드를 보여주고 한 번에 논리적으로 납득시키는 것도 중요함을 깨달음

/* 저번 Lv. 0 or 1에서 비슷한 유형의 문제가 있어서 그 방식을 이용했으나
테스트 15번에서 실패
그리고 비효율적인 로직이고 가독성이 매우 떨어지기 때문에 다른 방법을 사용
using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string str = s;
        while (true)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            foreach (char ch in s)
            {
                if (ch == '(')
                {
                    a++;
                }
                else if (ch == '[')
                {
                    b++;
                }
                else if (ch == '{')
                {
                    c++;
                }
                else if (ch == ')')
                {
                    a--;
                }
                else if (ch == ']')
                {
                    b--;
                }
                else if (ch == '}')
                {
                    c--;
                }
                
                if (a < 0 || b < 0 || c < 0)
                    break;
            }
            if (a == 0 && b == 0 && c == 0)
                answer++;
            
            s = s.Substring(1) + s[0];
            
            if (s == str)
                break;
        }
        
        return answer;
    }
}
*/
