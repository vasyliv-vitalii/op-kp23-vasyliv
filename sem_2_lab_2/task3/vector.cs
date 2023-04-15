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
            vector = cordinates.ToArray();
        }

        public static int operator +(Vector vec1, Vector vec2)
        {
            int sum = 0;
            foreach (var item in vec1.vector)
            {
                if (item < 0)
                {
                    sum += item;
                }
            }
            foreach (var item in vec2.vector)
            {
                if (item < 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        public static int operator *(Vector vec1, Vector vec2)
        {
            int prod = 0;
            int index1 = 1;
            int index2 = 1;
            for (int i = 0, j = 0; i < vec1.vector.Length; i++)
            {
                if (j < vec2.vector.Length)
                {
                    if (index2 % 2 == 0 && index1 % 2 == 0)
                    {
                        prod += vec1.vector[i] * vec2.vector[j];
                    }
                    index2++;
                    index1++;
                    j++;
                }

            }
            return prod;
        }

        public static int operator -(Vector vec1, Vector vec2)
        {
            int sum = 0;
            foreach (var item in vec1.vector)
            {
                if (item == 0)
                {
                    sum++;
                }
            }
            foreach (var item in vec2.vector)
            {
                if (item == 0)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
