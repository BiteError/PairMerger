using System;
using System.Collections.Generic;

namespace PairMerge
{
    public static class PairMerger
    {
        internal const int EmptyIndex = -1;

        public static List<int> Merge(List<int> inputList)
        {
            var result = new List<int>();
            var index = inputList.FindFirstNotZeroIndex();

            if (index == EmptyIndex)
                return result;

            result.Add(inputList[index]);
            MergeForward(inputList, index + 1, result);
            MergeBackward(result);

            return result;
        }        

        static void MergeForward(List<int> inputList, int index, List<int> resultList)
        {            
            if (inputList.CheckIndexOutOfRange(index)) 
                return;

            var currentElement = resultList.GetLastElement();

            if (inputList.CheckNotZeroOnIndex(index))
            {
                var nextElement = inputList[index];

                if (nextElement == currentElement)
                {
                    DoubeLastElement(resultList);
                }
                else
                {
                    MergeBackward(resultList);
                    resultList.Add(nextElement);
                }
            }

            MergeForward(inputList, index + 1, resultList);
        }        

        static void MergeBackward(List<int> result)
        {
            if (result.CheckNothingToMerge())
                return;

            if (result.CheckLastPair())
            {
                MergeLastElements(result);
                MergeBackward(result);
            }
        }

        static void DoubeLastElement(List<int> result)
        {
            result[result.Count - 1] += result[result.Count - 1];
        }

        static void MergeLastElements(List<int> result)
        {
            result[result.Count - 2] += result[result.Count - 1];
            result.RemoveAt(result.Count - 1);
        }
    }
}
