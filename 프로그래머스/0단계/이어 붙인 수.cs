using System;
using System.Text;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        var r1 = new StringBuilder();
        var r2 = new StringBuilder();
        
        for(int i=0; i<num_list.Length; i++) {
            if(num_list[i]%2==0) {
                r1.Append(num_list[i].ToString());
            } else {
                r2.Append(num_list[i].ToString());
            }
        }
        
        return int.Parse(r1.ToString())+int.Parse(r2.ToString());
    }
}