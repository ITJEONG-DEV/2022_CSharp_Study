using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.바탕화면_정리
{
    public class Solution
    {
        public int[] solution(string[] wallpaper)
        {
            int min_x = int.MaxValue, min_y = int.MaxValue;
            int max_x = int.MinValue, max_y = int.MinValue;

            for(int i=0; i<wallpaper.Length; i++)
            {
                var data = wallpaper[i].ToList();

                int first = data.IndexOf('#');
                int last = data.LastIndexOf('#');

                if(first != -1)
                {
                    if(min_x > first)
                    {
                        min_x = first;
                    }

                    if(min_y > i)
                    {
                        min_y = i;
                    }
                }

                if(last != -1)
                {
                    if(max_x < last)
                    {
                        max_x = last;
                    }

                    if(max_y < i)
                    {
                        max_y = i;
                    }
                }
            }

            return new int[4] { min_y, min_x, max_y+1, max_x+1 };
        }
    }
}
