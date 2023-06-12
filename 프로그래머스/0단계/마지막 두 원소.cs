using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int len = num_list.Length;
        int[] result = new int[len+1];
        
        num_list.CopyTo(result, 0);
        
        if(num_list[len-1] > num_list[len-2]) {
            result[len] = num_list[len-1]-num_list[len-2];
        } else {
            result[len] = num_list[len-1]*2;
        }
        
        return result;
    }
}