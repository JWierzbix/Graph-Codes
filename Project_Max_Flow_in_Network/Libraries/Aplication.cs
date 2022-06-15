using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Max_Flow_in_Network.Libraries
{
    public partial class Form1
    {
        public static void Aplikacja(string path)
        {
            int[,] G = Read_from_File(path);
            Ford_Fulkerson_Pomocniczy(G, 0, G.GetLength(0) - 1);
        }
    }
}
