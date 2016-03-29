using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetPasswordOfSmallCharacters()
        {
            Options password = new Options (1, 0, 0, 0, false, false) ;
            Assert.AreEqual(true, CheckSmallLettersOfAString(GetPassword(password)));
        }
        [TestMethod]
        public void TestToCheckSmallLetters()
        {
            string smallPassowrd = GetSmallLetters(5);
            Assert.AreEqual(true, CheckSmallLettersOfAString(smallPassowrd));
        }
        [TestMethod]
        public void TestToCheckForLowerAndUpperLetters()
        {
            Options password = new Options(4, 3, 0, 0, false, false) ;
            Assert.AreEqual(true, CheckForLowerAndUpperLetters(GetPassword(password)));
        }
         [TestMethod]
         public void TestCheckForLowerAndUpperLettersFunction()
         {
             Assert.AreEqual(true, CheckForLowerAndUpperLetters("abbccAAAA"));
         }
         [TestMethod]
         public void TestCountUpperLetters()
         {
             var bigPassword = GetBigLetters(5);
             Assert.AreEqual(4, CountUpperLetters(bigPassword));
         }
         [TestMethod]
         public void TestCountNumbersInPassword()
         {
             Assert.AreEqual(7,CountNumbers(GetNumbers(7)));
         }
         [TestMethod]
         public void TestForRemoveChars()
         {
             Assert.AreEqual("abc", RemoveChars("Iol10abc"));
         }
         [TestMethod]
         public void TestForRemoveAmbigueChars()
         {
             Assert.AreEqual("abc", RemoveAmbigueChars("{}abc[]()~"));
         }
         [TestMethod]
         public void TestForGenerateSymbols()
         {
             Assert.AreEqual((GenerateSymbols(4)),(GenerateSymbols(4)));
         }
         [TestMethod]
         public void TestForPasswordWithAllOptions()
         {
             Options password = new Options(10, 2, 3, 4, true, true) ;
             Assert.AreEqual(3, CountNumbers(GetPassword(password)));
         }

        string GetPassword(Options options)
        {
            string result = string.Empty;
                result = GetSmallLetters(options.smallChars) + GetBigLetters(options.noOfUpperChars) + GetNumbers(options.noOfNumbers) + GenerateSymbols(options.noOfSymbols);
                if (options.notIncludedSimilarChars)    
                {
                     result = RemoveChars(result);
                }
                if (options.notIncludedAmbigueChars)
                {
                     result = RemoveAmbigueChars(result);
                }
          
            return result;
        }
        string GetSmallLetters(int noOfSmallLetters)
        {
            string output = string.Empty;
            Random rand = new Random();

            while (noOfSmallLetters != 0)
            {
                int randomNumber = rand.Next(0, 26);
                char holdChar = (char)('a' + randomNumber);
                output += holdChar;
                noOfSmallLetters--;
            }
            return output;
        }
       
        public struct Options
        {
            public int smallChars;
            public int noOfUpperChars;
            public int noOfNumbers;
            public int noOfSymbols;
            public bool notIncludedSimilarChars;
            public bool notIncludedAmbigueChars;

            public Options(int smallChars, int noOfUpperChars, int noOfNumbers, int noOfSymbols, bool notIncludedSimilarChars, bool notIncludedAmbigueChars)
            {
                this.smallChars = smallChars;
                this.noOfUpperChars = noOfUpperChars;
                this.noOfNumbers = noOfNumbers;
                this.noOfSymbols = noOfSymbols;
                this.notIncludedSimilarChars = notIncludedSimilarChars;
                this.notIncludedAmbigueChars = notIncludedAmbigueChars;
            }
        }
       public bool CheckSmallLettersOfAString(string inputString)
        {

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (!(char.IsLower(inputString[i]))) 
                    return false;
            }
            return true;
        }
       public string GetBigLetters(int noOfLetters)
       {
           string output = GetSmallLetters(noOfLetters);
           return output.ToUpper();
       }
       bool CheckForLowerAndUpperLetters(string inputString)
       {
           return !(CheckSmallLettersOfAString(inputString) && CheckUpperLetters(inputString));
       }
       bool CheckUpperLetters(string inputString)
       {
           for (int i = 0; i < inputString.Length - 1; i++)
           {
               if ((!(char.IsUpper(inputString[i]))))
                   return false;
           }
           return true;
       }
       public int CountUpperLetters(string inputString)
       {
           int count = 0;
           for (int i = 0; i < inputString.Length - 1; i++)
           {
               if ((char.IsUpper(inputString[i]))) 
                   count++;
           }
           return count;
       }
       string GetNumbers(int noOfNumbers)
       {
           int holder = 0;
           string output = string.Empty;
           Random rand = new Random();
           while (noOfNumbers != 0)
             {
                 holder = rand.Next(0, 9);
                 output += holder;
                 noOfNumbers--;
             }
           return output;
       }
        int CountNumbers(string inputString) 
        {
            int count = 0;
            for (int i = 0; i < inputString.Length;i++ )
            {
                int nr = (int)Char.GetNumericValue(inputString[i]);
                if (nr >= 0 && nr <= 9)
                {
                    count++;
                } 
            }
            return count;
        }
        string RemoveChars(string inputString, string charsToRemove = "l1IoO0")
        {
           string result = string.Empty;
           for (int i = 0; i < inputString.Length; i++)
             {
                 if (!charsToRemove.Contains(inputString[i].ToString()))
                     result += inputString[i];             
             }
             return result;
        }
        string RemoveAmbigueChars(string inputString)
        {
            return RemoveChars(inputString, "{}[]()/\'~,;.<> ");        
        }
        string GenerateSymbols(int numberOfSymbols)
        {
            int k = 0;
            int holder;
            string output = string.Empty;
            Random rand = new Random();
            while(k != numberOfSymbols)
            {
                holder = rand.Next(' ', '/');
                output += (char)holder;
                
                RemoveAmbigueChars(output);
               
                k = output.Length;
                k++;
            }
            return output;
        }
       
    }
}

