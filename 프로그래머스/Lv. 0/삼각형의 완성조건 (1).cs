using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        
        int _max = 0;
        int _twoSide = 0;
        
        foreach (int side in sides)
        {
            if(_max < side)
            {
                _twoSide += _max;
                _max = side;
            }       
            else
                _twoSide += side;  
        }
        
        if(_max < _twoSide)
            answer = 1;
        else
            answer = 2;

        //return sides.Max() < (sides.Sum() - sides.Max()) ? 1 : 2; 한 줄로 간단히 표현 가능
        return answer;
    }
}
