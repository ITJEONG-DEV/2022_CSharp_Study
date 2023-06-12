using System;

public class Solution {
    public int solution(int a, int b) {
        int r1 = int.Parse(a.ToString() + b.ToString());
        int r2 = 2*a*b;
        
        return r1>r2? r1: r2;
    }
}