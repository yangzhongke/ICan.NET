using System.Collections.Generic;

namespace System.Linq
{
    /// <summary>
    /// Sliding Windows over items. Optimized for T[] and IList<T>
    /// </summary>
    public static class SliceWindowExtensions
    {
        public static IEnumerable<T[]> Window<T>(this T[] items, int windowSize)
        {
            if(windowSize<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(windowSize),"windowsSize must be positive");
            }
            if(windowSize>items.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(windowSize), "windowsSize must not be greater than items.Length");
            }
            int head = 0;
            int tail = windowSize-1;
            while(tail<items.Length)
            {
                T[] windowItems = new T[windowSize];
                for (int i = 0; i < windowSize; i++)
                {
                    windowItems[i] = items[head+i];
                }
                yield return windowItems;
                head++;
                tail++;
            }
        }

        public static IEnumerable<T[]> Window<T>(this IList<T> items, int windowSize)
        {
            if (windowSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(windowSize), "windowsSize must be positive");
            }
            int count = items.Count;
            if (windowSize > count)
            {
                throw new ArgumentOutOfRangeException(nameof(windowSize), "windowsSize must not be greater than items.Count");
            }
            int head = 0;
            int tail = windowSize - 1;
            while (tail < count)
            {
                T[] windowItems = new T[windowSize];
                for (int i = 0; i < windowSize; i++)
                {
                    windowItems[i] = items[head + i];
                }
                yield return windowItems;
                head++;
                tail++;
            }
        }


        public static IEnumerable<T[]> Window<T>(this IEnumerable<T> items,int windowSize)
        {
            if (windowSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(windowSize), "windowsSize must be positive");
            }
            int count = items.Count();
            if (windowSize > count)
            {
                throw new ArgumentOutOfRangeException(nameof(windowSize), "windowsSize must not be greater than items.Count");
            }
            int head = 0;
            int tail = windowSize - 1;
            while (tail < count)
            {
                T[] windowItems = new T[windowSize];
                for (int i = 0; i < windowSize; i++)
                {
                    windowItems[i] = items.ElementAt(head + i);
                }
                yield return windowItems;
                head++;
                tail++;
            }
        }
    }
}
