using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Max_Flow_in_Network
{
    public partial class Project
    {
        //waga 0 jest dla par wierzchołków, które nie są połączone przez żadną krawędź
        //waga >= 0 jest dla par wierzchołków, które są połączone krawędzią skierowaną
        /// <summary>
        /// Algorytm oblicza nam maksymalny przepływ w sieci
        /// </summary>
        /// <param name="G">Macierz sąsiedztwa grafu</param>
        /// <param name="start">wierzchołek startowy grafu - źródło</param>
        /// <param name="stop">wierzchołek końcowy grafu - ujście</param>
        public void Ford_Fulkerson_Pomocniczy(int[,] G, int start, int stop)
        {
            int licznik = 0;
            List<Vertex> ścieżka;
            do
            {
                //wyświetlanie danych z BFS na konsolę
                ścieżka = BFS(G, licznik);
                int min = int.MaxValue;
                foreach (Vertex v in ścieżka)
                {
                    min = Math.Min(min, v.distance);
                }
                string minimum = "min{";
                foreach (Vertex v in ścieżka)
                {
                    minimum += v.distance;
                    if (v != ścieżka[ścieżka.Count - 1])
                    {
                        minimum += ',';
                    }
                }
                minimum += "}= " + min;
                output += minimum+"\n";
                output += "================== \n";
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
            output += $"Makymalny przepływ w sieci wynosi: {max_flow}";
            output += "\n \n";
        }
    }
}
