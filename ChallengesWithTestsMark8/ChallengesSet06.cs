using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true) 
            {
                word = word.ToLower();
                List<string> list = words.Select(x => x.ToLower()).ToList();
                containsWord = list.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }
            if (num == 2 || num == 3)
            {
                isPrime = true;
            }
            if (num == 1)
            {
                isPrime = false;
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool uIndex;
            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }
                if (uIndex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var counter = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > counter)
                {
                    counter = currentCount;
                }
                
            }
            return counter;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var output = new List<double>();
            if (elements == null)
            {
                return output.ToArray();
            }
            if (n <= 0)
            {
                return output.ToArray();
            }

            for (int i = n-1; i < elements.Count;)
            {
                output.Add(elements[i]);
                i += n;
            }
            return output.ToArray();
        }
    }
}
