using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.빛의_경로_사이클
{
    class Solution
    {
        public enum Direction{ NONE = 0, LEFT, RIGHT, UP, DOWN };
        (int, int)[] directionVector = { (0, -1), (0, 1), (-1, 0), (1, 0) };

        public enum NodeType { S =0, L, R };

        public int[,] MakeArr(ref string[] grid)
        {
            int height = grid.Length;
            int width = grid[0].Length;

            int[,] arr = new int[height, width];

            for(int i=0; i<height; i++)
                for(int j=0; j<width; j++)
                    switch (grid[i][j])
                    {
                        case 'S':
                            arr[i, j] = (int)NodeType.S;
                            break;
                        case 'L':
                            arr[i, j] = (int)NodeType.L;
                            break;
                        case 'R':
                            arr[i, j] = (int)NodeType.R;
                            break;
                    }

            return arr;
        }

        // 기존의 빛의 방향과 도착 노드에 따른 새로운 이동 방향 반환
        public Direction GetDirection(NodeType nodeType, Direction direction)
        {
            if (nodeType == NodeType.S)
                return direction;

            if (nodeType == NodeType.L)
                switch (direction)
                {
                    case Direction.LEFT:
                        return Direction.DOWN;
                    case Direction.RIGHT:
                        return Direction.UP;
                    case Direction.DOWN:
                        return Direction.RIGHT;
                    case Direction.UP:
                        return Direction.LEFT;
                }

            if(nodeType == NodeType.R)
                switch(direction)
                {
                    case Direction.LEFT:
                        return Direction.UP;
                    case Direction.RIGHT:
                        return Direction.DOWN;
                    case Direction.DOWN:
                        return Direction.LEFT;
                    case Direction.UP:
                        return Direction.RIGHT;
                }

            return Direction.NONE;
        }


        public int CheckCycle(int currentX, int currentY, Direction currentDirection, int startX, int startY, Direction startDirection, ref int[,] arr, bool isStart, ref bool[,,] log)
        {
            // 시작 노드의 위치, 방향이 모두 같은 경우 한 사이클을 돌았다고 간주하고 종료함
            if (!isStart && currentX == startX && currentY == startY && currentDirection == startDirection)
                return 0;

            // 현재 노드의 위치와 이동 방향 탐색 표시
            log[currentX, currentY, (int)currentDirection -1] = true;

            // 현재 빛의 이동 방향의 벡터를 가져옴
            var vector = directionVector[(int)currentDirection - 1];

            // 현재 노드의 타입을 가져 옴
            NodeType currentNode = (NodeType)arr[currentX, currentY];

            // 현재 노드에서 이동 방향으로 이동했을 때의 새로운 위치 계산
            int newX = currentX + vector.Item1;
            if (newX >= arr.GetLength(0))
                newX -= arr.GetLength(0);
            if (newX < 0)
                newX += arr.GetLength(0);

            int newY = currentY + vector.Item2;
            if (newY >= arr.GetLength(1))
                newY -= arr.GetLength(1);
            if (newY < 0)
                newY += arr.GetLength(1);

            NodeType newNode = (NodeType)arr[newX, newY];

            // 새로운 노드에서의 빛의 이동방향 다시 계산
            Direction newDirection = GetDirection(newNode, currentDirection);

            //Console.WriteLine($"현재 위치: ({currentX}, {currentY}), 노드: {currentNode} - 방향: {currentDirection}, 새로운 위치: ({newX}, {newY}), 새로운 방향: {newDirection}");

            // 길이 + 1 하여 사이클 탐색
            return 1 + CheckCycle(newX, newY, newDirection, startX, startY, startDirection, ref arr, false, ref log);
        }

        public int[] CheckCycles(ref int[,] arr)
        {
            List<int> answer = new List<int>();
            
            // 중복 사이클을 확인하기 위한 로그
            bool[,,] log = new bool[arr.GetLength(0), arr.GetLength(1), 4];

            // 각 노드에서 각 방향으로 시작하는 모든 경우의 수를 고려함
            for(int i=0; i<arr.GetLength(0); i++)
                for(int j=0; j<arr.GetLength(1); j++)
                    foreach(Direction direction in new Direction[] { Direction.UP, Direction.DOWN, Direction.LEFT, Direction.RIGHT})
                    {
                        // 같은 노드에서 같은 방향으로 탐색한 경우가 있는 경우, 중복 사이클로 탐지함
                        if (log[i, j, (int)direction-1])
                            continue;

                        //Console.WriteLine($"({i}, {j}, {direction})에서부터 탐색 시작");

                        int result = CheckCycle(i, j, direction, i, j, direction, ref arr, true, ref log);

                        //Console.WriteLine($"탐색 완료. 사이클의 길이: {result}");
                        // 중복이 아닌 경우의 사이클만 탐색함
                        answer.Add(result);
                    }

            // 오름차순 정렬하여 int[]로 반환
            return answer.OrderBy((x)=>x).ToArray();
        }

        public int[] solution(string[] grid)
        {
            // 연산에 용이한 int[] arr 만들기
            var arr = MakeArr(ref grid);

            return CheckCycles(ref arr);
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            string[] grid1 = new string[] { "SL", "LR" };
            string[] grid2 = new string[] { "S" };
            string[] grid3 = new string[] { "R", "R" };
            
            var result = solution.solution(grid3);

            for(int i=0; i<result.Length; i++)
                Console.Write(result[i] + " ");
        }
    }
}
