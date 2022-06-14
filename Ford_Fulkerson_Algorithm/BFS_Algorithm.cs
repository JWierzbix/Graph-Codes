using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ford_Fulkerson_Algorithm
{
    //POMOCNICZY ALGORYTM BFS DO PRZESZUKIWANIA SIECI RESIDUALNEJ
    partial class Program
    {
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
                        visited[i].distance = G[v, i];
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
            Console.WriteLine("==================");
            Console.WriteLine($"Wynik {licznik} pętli BFS:");
            Console.WriteLine("---------");
            foreach (Vertex v in ścieżka)
            {
                Console.WriteLine($"{v.previous}-{v.number} waga:{v.distance}");
            }
            Console.WriteLine("------------------");

            return ścieżka;
        }
    }
}
