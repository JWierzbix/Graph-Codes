using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BFS_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 przykład
            int[,] G1 = { {0,0,0,1,0 },
                         {0,0,1,1,1 },
                         {0,1,0,0,0 },
                         {1,1,0,0,1 },
                         {0,1,0,1,0 }
                           };
            //2 przykład- graf skierowany, asymetryczny
            int[,] G2 = { {0,5,0,4,0,0 },
                          {7,0,0,0,7,0 },
                          {0,5,0,1,0,3 },
                          {3,0,3,0,6,0 },
                          {0,2,0,2,0,8 },
                          {0,0,6,0,4,0 }
                           };
            BFS(G2);
            Console.ReadKey();
        }
        public static void BFS(int[,] G)
        {
            if (G.GetLength(0) == 0) return; //warunek stopu
            //inicjalizacja zmiennych
            Queue<int> kolejka = new Queue<int>();
            Vertex[] visited = new Vertex[G.GetLength(0)];
            for (int i = 0; i < G.GetLength(0) ; i++)
            {
                visited[i] = new Vertex();
                visited[i].number = i;
            }
            //inicjalizacja pętli - wsadzamy pierwszy element 
            kolejka.Enqueue(0);
            visited[0].visited = true;
            visited[0].distance = 0;
            visited[0].previous = -1;//-1 oznacza że nie miał przodka i jest początkowy
            //rozpoczynamy pętlę
            int last = -1;
            while(kolejka.Count != 0)
            {
                int v = kolejka.Dequeue();
                last = v;
                for (int i = 0; i < G.GetLength(1); i++)
                {
                    if (G[v, i] != 0 && visited[i].visited == false)
                    {
                        kolejka.Enqueue(visited[i].number);
                        visited[i].visited = true;
                        visited[i].distance = visited[v].distance + 1;
                        visited[i].previous = v;
                    }
                }
            }
            while(visited[last].previous != -1)
            {
                int before_last = visited[last].previous;
                Console.WriteLine($"{visited[before_last].number}-{visited[last].number}");
                last = before_last;
            }
        }
    }
    class Vertex
    {
        public bool visited;
        public int number;       
        public int distance;
        public int previous;        
    }
}
