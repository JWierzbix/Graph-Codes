using System;
namespace DNS
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            int[,] G = { {0,0,0,1,0 },
                         {0,0,1,1,1 },
                         {0,1,0,0,0 },
                         {1,1,0,0,1 },
                         {0,1,0,1,0 }
                           };
                        
            DFS(G);            
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
                    Explore(G, ref odwiedzone, i,ref licznik);
                    licznik++;
                }
            }            
            odwiedzone[v].post = licznik;
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
