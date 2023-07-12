using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.테이블_해시_함수
{
    public class Solution
    {
        public class Column
        {
            public int[] data;

            public Column(int[] data)
            {
                this.data = data;
            }

            public int CompareTo(Column other, int col)
            {
                if (this.data[col] == other.data[col])
                {
                    return -(this.data[0] - other.data[0]);
                }
                else
                {
                    return this.data[col] - other.data[col];
                }
            }
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.solution(new int[,] { { 2, 2, 6 }, { 1, 5, 10 }, { 4, 2, 9 }, { 3, 8, 3 } }, 2, 2, 3);
            Console.WriteLine(r);
        }

        public int GetSI(int i, Column column)
        {
            int sum = 0;
            for(int index=0; index<column.data.Length; index++)
            {
                sum += column.data[index] % (i+1);
            }
            return sum;
        }

        public int solution(int[,] data, int col, int row_begin, int row_end)
        {
            List<Column> columns = new List<Column>();
            for(int i=0; i<data.GetLength(0); i++)
            {
                int[] columnArr = new int[data.GetLength(1)];

                for(int j=0; j<data.GetLength(1); j++)
                {
                    columnArr[j] = data[i, j];
                }

                Column column = new Column(columnArr);
                columns.Add(column);
            }

            columns.Sort(new Comparison<Column>((c1, c2) => (c1.CompareTo(c2, col-1))));

            int sum = -1;
            for(int i=row_begin - 1; i<=row_end-1; i++)
            {
                if (i==row_begin-1) sum = GetSI(i, columns[i]);
                else sum ^= GetSI(i, columns[i]);
            }

            return sum;
        }
    }
}
