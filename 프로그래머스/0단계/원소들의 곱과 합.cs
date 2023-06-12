using System;

public class Solution {
    public int product(int[] num_list) {
        var res = 1;
        
        for(int i=0; i<num_list.Length; i++) {
            res *= num_list[i];
        }
        
        return res;
    }
    public int squareSum(int [] num_list) {
        var res = 0;
        
        for(int i=0; i<num_list.Length; i++) {
            res += num_list[i];
        }
        
        return res*res;
    }
    public int solution(int[] num_list) {
        var r1 = product(num_list);
        var r2 = squareSum(num_list);
        
        return r1>r2?0:1;
    }
}