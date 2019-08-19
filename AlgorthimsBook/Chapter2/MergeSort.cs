using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorthimsBook.Chapter2
{
    public class MergeSortMechanism
    {
        public MergeSortMechanism()
        {
        }

        public int [] MergeSortRecursively(int [] a)
        {
            if (a.Length <= 1) return a;

            else
            {
                int half = a.Length / 2;

                return Merge(MergeSortRecursively(splitArray(a, 0, half)), MergeSortRecursively(splitArray(a, half,a.Length)));
            }
        }

        private int [] Merge(int [] x , int [] y)
        {
            if (x.Length == 0) return y;
            if (y.Length == 0) return x;

            if(x[0] >= y[0])
            {
                return concatenateElmtoArray(y[0], Merge(splitArray(x, 0, x.Length), splitArray(y, 1, y.Length)));
            } else {
                return concatenateElmtoArray(x[0],Merge(splitArray(x, 1, x.Length), splitArray(y,0, y.Length)));
            }

        }

        public int [] splitArray(int [] a, int start , int end)
        {
            return a.Skip(start).Take(end).ToArray();
        }

        public int [] concatenateElmtoArray(int elm, int[] arr)
        {
            int[] result = new int[arr.Length + 1];

            result[0] = elm;

            for (int i = 0; i < arr.Length; i++)
            {
                result[i + 1] = arr[i];
            }

            return result;
        }


        public int [] MergeSortIteratively(int [] ar)
        {
            Queue<int[]> q = new Queue<int[]>();

            for (int i = 0; i < ar.Length; i++)
            {
                q.Enqueue(splitArray(ar,i,1));
            }

            while(q.Count > 1)
            {
                int [] ar1 = q.Dequeue();
                int[] ar2 = q.Dequeue();
                q.Enqueue(Merge(ar1, ar2));
            }

            return q.Dequeue();
        }
    }
}
