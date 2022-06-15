using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ford_Fulkerson_Algorithm
{
    partial class Program
    {
        public static void Aplikacja()
        {
            int[,] G = Read_from_File("C:/Users/Kuba/Desktop/dane.txt");
            Ford_Fulkerson_Pomocniczy(G, 0, G.GetLength(0) - 1);
        }
    }
}