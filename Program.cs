using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace DuplicateCharacter
{
    class Program
    {

       public static List<WordInformation> wordInformationList { get; set; } 
        static void Main(string[] args)
        {
            // FindDuplicateCharacter("Code test sssssssss bbbbbbbbb ccccccccccc");
            // FindCommonPrefix();
            //   search("Code test", "e");

            //   SegregateNegative();
            wordInformationList = new List<WordInformation>();
            FindWordCount();
            Console.ReadLine();
        }

        /// <summary>
        /// Question 1
        /// </summary>
        /// <param name="InputString"></param>
        public static void FindDuplicateCharacter(string InputString)
        {
            StringBuilder stringBuilder = new StringBuilder();
         
            for (int i=0;i< InputString.Length; i++)
            {
                int count = 0;
                if (!(stringBuilder.ToString().Contains(InputString[i].ToString())))
                {
                    for (int j = 0; j < InputString.Length; j++)
                    {
                        if(InputString[i]== InputString[j])
                        {

                            count = count + 1;
                            int newCount=count;
                        }
                    }
                    stringBuilder.Append(String.Format("{0}={1},", InputString[i], count));
                }
             
               
            }
            

            Console.WriteLine(stringBuilder.ToString());
        }

        /// <summary>
        /// Question 3
        /// </summary>
       public static void FindCommonPrefix()
        {
            string[] strringArray =  { "Moreck-test", "Morening", "More" };
            int index = 0;
            int count = 1;
            StringBuilder prefix = new StringBuilder();
            foreach(char character in strringArray[index])
            {
                for(int i=1;i< strringArray.Length;i++)
                {
                    if(index< strringArray[i].Length && character == strringArray[i][index])
                    {

                        count = count + 1;
                        if (count == strringArray.Length)
                        {
                            prefix.Append(character);
                            count = 1;
                            index = index + 1;
                            break;
                        }
                    }
                    
                   

                }

            }

            Console.WriteLine(prefix.ToString());
        }


        public static void SegregateNegative()
        {
            int[] intArray = new int[] { 7, 11, -2, -8, 6, -3, -4, 2 };

            int[] intArrayTemp = new int[intArray.Length];
            int index = 0;
            int start = 0;
            int end = intArray.Length - 1;
            while (index < intArray.Length )
            {
                if (intArray[index] < 0)
                {
                    intArrayTemp[start] = intArray[index];
                    start = start + 1;
                    index = index + 1;
                }
                else
                {
                    intArrayTemp[end] = intArray[index];
                    end = end - 1;
                    index = index + 1;
                }

            }

        }

       public static void FindWordCount()
        {
           
            string[] stringArray = new string[] { "Amb", "Uma", "Nil", "Uma", "Amb", "Amb" };
            int index = 0;
            foreach(string word in stringArray )
            {
                if(stringArray[index]==word)
                {
                    WordIsAvailable(word, wordInformationList);

                }
                index = index + 1;
                //this message will be push to branch new
            }

        }

        public static void WordIsAvailable(string word,List<WordInformation> wordInformationList)
        {
            if (wordInformationList.Count == 0)
            {
                wordInformationList.Add(new WordInformation() { Word = word, WordCount = 1 });
            }
            else
            {
                foreach (WordInformation wordItrm in wordInformationList)
                {
                    if (wordItrm.Word == word)
                    {
                        wordItrm.WordCount = wordItrm.WordCount + 1;

                    }
                    else
                    {
                        wordInformationList.Add(new WordInformation() { Word = word, WordCount = 1 });
                    }
                }
            }
           
        }
       
    }

    public class WordInformation
    {
        public int WordCount { get; set; }
        public string Word { get; set; }
    }
}
