using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.영어가_싫어요
{
    public class Solution
    {
        public long solution(string numbers)
        {
            numbers = numbers.Replace("zero", "0");
            numbers = numbers.Replace("one", "1");
            numbers = numbers.Replace("two", "2");
            numbers = numbers.Replace("three", "3");
            numbers = numbers.Replace("four", "4");
            numbers = numbers.Replace("five", "5");
            numbers = numbers.Replace("six", "6");
            numbers = numbers.Replace("seven", "7");
            numbers = numbers.Replace("eight", "8");
            numbers = numbers.Replace("nine", "9");

            long answer = long.Parse(numbers);
            return answer;
        }
    }
}
