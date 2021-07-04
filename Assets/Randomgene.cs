using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;

namespace System.Linq.Extension
{
    public static class ListExtension
    {
        public static IEnumerable<T> GetRandom<T>(this IList<T> list, int count)
        {
            var random = new Random();

            var indexList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                indexList.Add(i);
            }

            for (int i = 0; i < count; i++)
            {
                int index = random.Next(0, indexList.Count);
                int value = indexList[index];
                indexList.RemoveAt(index);
                yield return list[value];
            }
        }
    }
}