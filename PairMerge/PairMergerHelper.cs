using System;
using System.Collections.Generic;

namespace PairMerge
{
    static class PairMergerHelper
    {
        public static int FindFirstNotZeroIndex(this List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 0)
                {
                    return i;
                }
            }
            return PairMerger.EmptyIndex;
        }

        public static bool CheckNothingToMerge(this List<int> list)
        {
            return list.Count == 1;
        }

        public static bool CheckLastPair(this List<int> list)
        {
            return list[list.Count - 2] == list[list.Count - 1];
        }

        public static bool CheckNotZeroOnIndex(this  List<int> list, int index)
        {
            return list[index] != 0;
        }

        public static int GetLastElement(this List<int> list)
        {
            return list[list.Count - 1];
        }
        
        public static bool CheckIndexOutOfRange(this List<int> list, int index)
        {
            return list.Count <= index || index < 0;
        }
    }
}