using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ford_Fulkerson_Algorithm
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //1 przykład- graf skierowany, asymetryczny
            int[,] G1 = { {0,5,0,4,0,0 },
                          {7,0,0,0,7,0 },
                          {0,5,0,1,0,3 },
                          {3,0,3,0,6,0 },
                          {0,2,0,2,0,8 },
                          {0,0,6,0,4,0 }
                           };
            //2 przykład- graf skierowany, asymetryczny
            int[,] G2 = {
                           {0,3,0,2,0,9,0,0 },//0
                           {0,0,6,0,0,0,0,0 },//1
                           {0,0,0,7,0,0,0,2 },//2
                           {0,0,0,0,0,0,5,0 },//3
                           {0,2,0,0,0,0,0,4 },//4
                           {0,0,0,0,7,0,1,0 },//5
                           {0,0,0,0,0,0,0,6 },//6
                           {0,0,0,0,0,0,0,0 }//7
                             };
            //Ford_Fulkerson_Pomocniczy(G2,0,7);
            Read_from_File("C:/Users/Kuba/Desktop/dane.txt");            
            Console.ReadKey();
        }               
    }   
}
