using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ford_Fulkerson_Algorithm
{
    partial class Program
    {
        /*plik ma zawierać macierz sąsiedztwa w postaci:
         * {x,x,x,x},
         * {x,x,x,x},
         * {x,x,x,x},
         * {x,x,x,x}
         * 1. W każdej linijce musi się znajdować jeden nawias klamrowy z danymi w środku
         * 2. Każdy element w nawiasie musi być oddzielony przecinkiem bez używania spacji
         * Przykład: 
         *      poprawnie: {-1,0,2,1}
         *      błędnie: {-1 ,2 ,3,0}
         * 3. Macierz musi być kwadratowa i musi przedstawiać graf skierowany, to znaczy musi być sieć residualna
         * 4. W macierzy nie mogą znajdować się wartości ujemne
         */
        /// <summary>
        /// metoda wczytująca dane z pliku tekstowego do wykonania algorytmu Forda-Fulksersona
        /// </summary>
        /// <param name="path">URL ścieżki pliku z danymi</param>
        public static int[,] Read_from_File(string path)
        {
            //wczytanie danych z pliku
            StreamReader sr = new StreamReader(path);
            string dane = sr.ReadToEnd();
            sr.Close();            
            //obliczamy rozmiar macierzy
            int rozmiar = 0;
            foreach (char item in dane)
            {
                if (item == '{' || item == '}') rozmiar++;
            }
            rozmiar /= 2; //ponieważ macierz musi być kwadratowa, to znajomość ilości nawiasów wystarczy nam do utowrzenia macierzy
            //tworzymy macierz
            int[,] G = new int[rozmiar, rozmiar];
            //wstawiamy dane do macierzy
            int licznik1 = 0;
            int licznik2 = 0;            
            int indeks = 0;
            string element = "";
            foreach (char item in dane)
            {
                if (item == '{')
                {
                    licznik1++;                    
                }
                if (item == '}')
                {                    
                    //dodajemy ostatni element z wiersza
                    G[licznik1-1, indeks] = Convert.ToInt32(element);
                    element = "";
                    //zamykamy wiersz
                    licznik2++;
                    indeks = 0;
                }
                if (licznik1 > licznik2 && item == ' ') throw new Exception("pomiędzy poszczególnymi elementami nie mogą występować spacje!");
                if (licznik1 > licznik2 && item == '-') throw new Exception("pomiędzy poszczególnymi elementami nie mogą występować ujemne wartości!");
                //warunek sprawdzający czy dany znak jest liczbą
                //licznik1>licznik2 znaczy, że nawias jest otwarty ale jeszcze nie zamknięty
                if(item >= 48 && item <= 57 && licznik1 > licznik2)
                {
                    element += item;
                }
                if(licznik1 > licznik2 && item == ',')
                {
                    G[licznik1-1, indeks] = Convert.ToInt32(element);
                    element = "";
                    indeks++;
                }
            }            
            return G;
        }
    }
}
