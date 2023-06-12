using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string str1, string str2) {
        StringBuilder result = new StringBuilder();
        
        for(int i=0; i<str1.Length; i++) {
            result.Append(str1[i]);
            result.Append(str2[i]);
        }
        
        return result.ToString();
    }
}