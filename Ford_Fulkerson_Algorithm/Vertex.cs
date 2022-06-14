using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ford_Fulkerson_Algorithm
{
    class Vertex
    {
        public bool visited; /* wartośc boolowska, mówiąca nam, 
        czy dany wierzchołek został już odwiedzony */

        public int number;/* numer wierzchołka */

        public int distance;/* długość krawędzi, pomiędzy 
        wierzchołku o numerze "number", a wierzchołkime o numerze "previous" */

        public int previous;/* wierzchołek poprzedzający wierzchołek o numerze
        "number", podczas przeszukiwania algorytmem BFS */
    }
}
