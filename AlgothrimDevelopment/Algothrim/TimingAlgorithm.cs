using System;
using System.Diagnostics;

namespace AlgothrimDevelopment.Algothrim
{
    public class TimingAlgorithm
    {
        public static string TimeAlgorithm(Client.SortingFunction sortFunction, GenerateArrays.GenerateArray generateArray, int arraySize)
        {

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            sortFunction(generateArray(arraySize));
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            return elapsedTime;
        }
    }
}