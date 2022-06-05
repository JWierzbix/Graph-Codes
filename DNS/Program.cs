using System;
namespace DNS
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            //1 przykład
            int[,] G1 = { {0,0,0,1,0 },
                         {0,0,1,1,1 },
                         {0,1,0,0,0 },
                         {1,1,0,0,1 },
                         {0,1,0,1,0 }
                           };

            //2 przykład
            int[,] G2 = { {0,1,0,0,1,0,0,0,0,0,0,0},
                         {1,0,0,0,0,0,0,0,0,0,0,0},
                         {0,0,0,1,0,0,1,1,0,0,0,0},
                         {0,0,1,0,0,0,0,1,0,0,0,0},
                         {1,0,0,0,0,0,0,0,1,1,0,0},
                         {0,0,0,0,0,0,0,0,0,0,0,0},
                         {0,0,1,0,0,0,0,1,0,0,1,0},
                         {0,0,1,1,0,0,1,0,0,0,1,1},
                         {0,0,0,0,1,0,0,0,0,1,0,0},
                         {0,0,0,0,1,0,0,0,1,0,0,0},
                         {0,0,0,0,0,0,1,1,0,0,0,0},
                         {0,0,0,0,0,0,0,1,0,0,0,0}
                           };

            DFS(G1);         
        }
        public static void CzyMaCykle(int[,] G, Vertex[] visited)
        {
            int cykle = 0;
            string zapis = ""; 
            for (int i = 0; i < visited.Length; i++)
            {
                for (int j = 0; j < visited.Length; j++)
                {
                    if (i == j) continue;
                    if (visited[i].pre < visited[j].pre && visited[j].pre < visited[j].post && visited[j].post < visited[i].post && G[i, j] == 1)
                    {
                        cykle++;
                        zapis += $"{(char)(65+i)}-{(char)(65 + j)} \n";
                    }
                }
            }            
            Console.WriteLine("Graf G ma {0} cykli:",cykle);
            Console.WriteLine(zapis);
        }
        public static void DFS(int[,] G)
        {
            Vertex[] odwiedzone = new Vertex[G.GetLength(0)];
            int spojne_składowe = 0;
            for (int i = 0; i < odwiedzone.Length; i++) //inicjalizacja wierzchołków 
            {
                odwiedzone[i] = new Vertex();
            }
            int licznik = 0;
            for (int i = 0; i < G.GetLength(0); i++) //przechodzenie graf w porządku rosnącym
            {
                if (odwiedzone[i].odwiedzone == false)
                {
                    spojne_składowe++;
                    Explore(G, ref odwiedzone, i, ref licznik);
                }
            }
            int a = 65;
            for (int i = 0; i < odwiedzone.Length; i++)
            {
                Console.WriteLine($"{(char)a}: " + odwiedzone[i]);
                a++;
            }
            Console.WriteLine("ilość spójnych skłądowych: {0}",spojne_składowe);
            Console.WriteLine("Czy graf jest spójny? -> {0}",spojne_składowe==1);
            CzyMaCykle(G,odwiedzone);
        }
        public static void Explore(int[,] G,ref Vertex[] odwiedzone,int v ,ref int licznik)
        {
            odwiedzone[v].odwiedzone = true;
            odwiedzone[v].pre = licznik;
            licznik++;
            for(int i = 0;i < G.GetLength(1); i++)
            {
                if(G[v,i]==1 && odwiedzone[i].odwiedzone == false)
                {
                    G[v, i] = -1;//zaznaczamy że ta krawędź została już odwiedzona
                    Explore(G, ref odwiedzone, i,ref licznik);                    
                }
            }            
            odwiedzone[v].post = licznik;
            licznik++;
        }
    }
    public class Vertex
    {
        public bool odwiedzone;
        public int pre;
        public int post;
        public override string ToString()
        {
            return $"pre={pre+1} post={post+1}";
        }
    }
}
