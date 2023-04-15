using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task3
{
    internal class Vector
    {
        public int[] vector;
        public Vector(params int[] cordinates)
        {
        }

        public static int operator +(Vector vec1, Vector vec2)
        {
            int sum = 0;  
            return sum;
        }

        public static int operator *(Vector vec1, Vector vec2)
        {
            int prod = 0;
            int index1 = 1;
            int index2 = 1;          
            return prod;
        }

        public static int operator -(Vector vec1, Vector vec2)
        {
            int sum = 0;            
            return sum;
        }
    }
}
