using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (var  i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Length == 0)
            {
                return false;
            }
            
            var lastNum = numbers[0];
            foreach ( var n in numbers)
            {
                if (lastNum > n)
                {
                    return false;
                }
                lastNum = n;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            var lastNum = numbers[0];
            var eligible = new List<int>();
            for (int n = 1; n < numbers.Length; n++)
            {
                if (lastNum % 2 == 0)
                {
                    eligible.Add(numbers[n]);
                }
                lastNum = numbers[n];
            }
            return eligible.Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var output = "";
            if (words == null)
            {
                return "";
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().Length > 0)
                {
                    output += words[i].Trim() + " ";
                }
            }
            var stringOut = output.ToString();
            if (stringOut.Length == 0)
            {
                return "";
            }
            stringOut = stringOut.Trim();
            stringOut += ".";
            return stringOut;
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var output = new List<double>();
            if (elements == null)
            {
                return output.ToArray();
            }
            
            for (int i = 3 ;i < elements.Count;)
            {
                output.Add(elements[i]);
                i += 4;
            }
            return output.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }
    }
}
