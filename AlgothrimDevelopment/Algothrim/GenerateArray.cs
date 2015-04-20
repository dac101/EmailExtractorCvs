using System;

namespace AlgothrimDevelopment.Algothrim
{
    public class GenerateArrays
    {
        public delegate IComparable[] GenerateArray(int arraySize);

        public static IComparable[] GenerateArrayValue(int size)
        {
            Random N = new Random();
            IComparable[] a = new IComparable[size];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = N.Next() / 10000;
            }
            return a;
        }

        private static IComparable[] GenerateParitalySorted(int size)
        {
            double precentageSorted = 0.50;//control the prcentaage sorted 0.9 = 90% on so on
            Random random = new Random();
            int startValue = random.Next(size*size);
            double interval = precentageSorted * size;
            IComparable[] values = new IComparable[size];

            for (int i = 0; i < size; i++)
            {
                if (i >= (int)interval)
                {
                    values[i] = random.Next(i);
                }
                else
                {
                    values[i] = startValue++;
                }               
            }
            return values;
        }

        private static IComparable[] NonUniformDistributionsGaussian(int startNumber,int arraySize)
        {
            IComparable [] arr = new IComparable[arraySize];
            Double[] intervals = { ((1.00 / 6.00) * arraySize), ((2.00 / 6.00) * arraySize),
                ((3.00 / 6.00) * arraySize),((4.00 / 6.00) * arraySize),
                ((5.00 / 6.00) * arraySize), ((6.00 / 6.00) * arraySize) };
 
            for (var i = 0; i < arraySize; i++)
            {
               
                if (i <= (int)intervals[0])
                {
                    startNumber = startNumber + 1;                   
                }

                else if ( i <= (int)intervals[1])
                {
                    startNumber = startNumber  + 2;                    
                }
                else if (i <= (int)intervals[2])
                {
                    startNumber = startNumber + 3;
                }
                else if (i <= (int)intervals[3])
                {
                    startNumber = startNumber - 3;
                }
                else if (i <= (int)intervals[4])
                {
                    startNumber = startNumber - 3;
                }
                else 
                {
                    startNumber = startNumber  - 2;                     
                }
                arr[i] = startNumber;
            }
            return arr;
        }
    }
}