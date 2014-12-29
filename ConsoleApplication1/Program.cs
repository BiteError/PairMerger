using PairMerge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Введите числа через пробел. После ввода нажмите Enter:");
                
                var input = Console.ReadLine().Split();                
                var inputList = new List<int>();
                var errorList = new List<string>();

                FillLists(input, inputList, errorList);
                if (CheckAndPrintError(errorList))
                {
                    continue;
                }

                PrintResult(inputList);
            }
        }

        private static void PrintResult(List<int> inputList)
        {
            var outputList = PairMerger.Merge(inputList);
            Console.WriteLine("Получены следующие значения:");

            foreach (int outputValue in outputList)
            {
                Console.Write(outputValue);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static bool CheckAndPrintError(List<string> errorList)
        {
            if (errorList.Count > 0)
            {
                Console.WriteLine("Введены некорректные значения:");
                foreach (string errorValue in errorList)
                {
                    Console.Write(errorValue);
                    Console.Write(" ");
                }

                Console.WriteLine();
                Console.WriteLine();

                return true;
            }
            return false;
        }

        private static void FillLists(string[] input, List<int> inputList, List<string> errorList)
        {
            foreach (string element in input)
            {
                int value;
                if (int.TryParse(element, out value))
                {
                    inputList.Add(value);
                }
                else
                {
                    errorList.Add(element);
                }
            }
        }
    }
}
