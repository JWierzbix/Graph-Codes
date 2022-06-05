using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ford_Fulkerson_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 przykład- graf skierowany, asymetryczny
            int[,] G2 = { {0,5,0,4,0,0 },
                          {7,0,0,0,7,0 },
                          {0,5,0,1,0,3 },
                          {3,0,3,0,6,0 },
                          {0,2,0,2,0,8 },
                          {0,0,6,0,4,0 }
                           };
            Ford_Fulkerson(G2,0,5);
            Console.ReadKey();
        }
        public static void Ford_Fulkerson(int[,] G, int start, int stop) 
        {
            int licznik = 0;
            List<Vertex> ścieżka;
            do
            {
                ścieżka = BFS(G, licznik);
                int min = int.MaxValue;
                foreach(Vertex v in ścieżka)
                {
                    min = Math.Min(min,v.distance);
                }
                for (int i = 0; i < ścieżka.Count; i++)
                {
                    G[ścieżka[i].previous, ścieżka[i].number] -= min;
                    G[ścieżka[i].number, ścieżka[i].previous] += min;
                }
                licznik++;
            } while (ścieżka[0].number == stop);
            int max_flow = 0;
            for (int i = 0; i < G.GetLength(0); i++)
            {
                max_flow += G[stop, i];
            }
            Console.WriteLine($"Maxymalny przepływ: {max_flow}");
        }
        //algorytm pomocniczy BFS
        public static List<Vertex> BFS(int[,] G, int licznik)
        {
            if (G.GetLength(0) == 0) return null; //warunek stopu
            //inicjalizacja zmiennych
            Queue<int> kolejka = new Queue<int>();
            Vertex[] visited = new Vertex[G.GetLength(0)];
            for (int i = 0; i < G.GetLength(0); i++)
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
            while (kolejka.Count != 0)
            {
                int v = kolejka.Dequeue();
                last = v;
                for (int i = 0; i < G.GetLength(1); i++)
                {
                    if (G[v, i] != 0 && visited[i].visited == false)
                    {
                        kolejka.Enqueue(visited[i].number);
                        visited[i].visited = true;
                        visited[i].distance = G[v,i];
                        visited[i].previous = v;
                    }
                }
            }            
            List<Vertex> ścieżka = new List<Vertex>();            
            while (visited[last].previous != -1)
            {
                ścieżka.Add(visited[last]);
                last = visited[last].previous;
            }
            Console.WriteLine("------------------");
            Console.WriteLine($"pętla {licznik}:");
            Console.WriteLine("---------");
            foreach (Vertex v in ścieżka)
            {
                Console.WriteLine($"{v.previous}-{v.number} waga:{v.distance}");
            }
            Console.WriteLine("------------------");

            return ścieżka;
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
