using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCA_App
{
    /*
     The class contains the encryption algorithm,
     contines the encryption keys and dictionary,
     returns encrypted text.
     */
    public class Encryption
    {
        /*
        subSetAmount - the amount of sets that are generated.
        numOfNum - number of numbers whitin every set.
        numOfdigits - number of digits in each number whitin the set.
        path - string that hold the chyper file location.
        max = max number holds the highst number that can reached from d digits + 1.
        rnd - random object for generate number randomly, defined as readonly static random object.
        syncLock - new object for generate randmon number each time, defined as readonly static object.
        Dynamic keys adjustment is required
        */
        private Dictionary dictionary;
        private int subSetAmount; //The key n=3
        private int numOfNum; //The key m=4
        private int numOfdigits; //The key d=2
        private string path;
        private int max;
        private static readonly Random rnd = new Random();
        private static readonly object syncLock = new object();


        public Encryption(Dictionary newDictionary, int newSubSetAmount, int newNumofNum, int newNumofDigits, string newPath)
        {
            dictionary = new Dictionary(newDictionary);
            subSetAmount = newSubSetAmount;
            numOfNum = newNumofNum;
            numOfdigits = newNumofDigits;
            path = newPath;
            max = IntPow(10, numOfdigits);
        }

        /*
       MAIN ENCRYPTION PUNCTION!!!!!
       ----> problem - one more enter in the end that dont belong <------
       The function generateSet generate a set of numbers that encrypte a single sign.
       sign - char that needs to be encrypted.
       returns a list of integers.
       */
        public void generateSet()
        {
            char cr;
            int code;
            StreamReader reader = new StreamReader(path);
            List<int> subSet1;
            List<int> subSet2;
            List<int> final;

            while (reader.Peek() >= 0)
            {
                cr = (char)reader.Read();
                subSet1 = new List<int>();
                subSet2 = new List<int>();
                final = new List<int>();
                code = dictionary.searchByOriginal(cr);
                subSet1 = makeSubSet(code);
                subSet2 = makeSubSet(code);
                while (checkingSums(subSet1, subSet2, code))
                {
                    subSet2 = makeSubSet(code);
                }
                foreach (int i in subSet1)
                    final.Add(i);
                foreach (int j in subSet2)
                    final.Add(j);
                for (int k = 0; k < (subSetAmount - 2); k++)
                {
                    List<int> tmp = new List<int>();
                    tmp = makeSubSet(code);
                    foreach (int x in tmp)
                        final.Add(x);
                }
                createEncrypeFile(final);
            }

        }


        /*
        The sub-function RandomNumber generate number according to synchronize clock.
        min - minimum value 
        max - maximum value
        the sub-function returns a random integer.
        */
        protected static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return rnd.Next(min, max);
            }
        }

        /*
       The sub-function makeSubSet generete set of numbers to encrypte a singel sign.
       targetNum - the number that represent the sign in the dictionary.
        */
        protected List<int> makeSubSet(int targetNum)
        {
            List<int> numOfNumsList = new List<int>();
            int dif = targetNum;
            int randomNextNum, targetAmount;
            int maxRandom = max;
            targetAmount = RandomNumber(2, numOfNum + 1); //Generating the amount of number in the subset that is going to sum to the target number
            randomNextNum = RandomNumber((max / 10), maxRandom); //first number of the list that is part of the target number
            dif -= randomNextNum; // the difference that left to the target number
            targetAmount--;
            numOfNumsList.Add(randomNextNum);
            while (targetAmount > 1 && dif > (max / 10))
            {
                if (dif < (max - 1)) // check what is the highest number that can be generated
                    maxRandom = dif;
                randomNextNum = RandomNumber(10, maxRandom);
                dif -= randomNextNum;
                targetAmount--;
                numOfNumsList.Add(randomNextNum);
            }
            if (dif > (max - 1)) //correct the last two numbers to reach the sum and being 2 digits
            {
                int last = numOfNumsList.Last();
                numOfNumsList.Remove(randomNextNum);
                numOfNumsList.Add(last + (dif - (max - 1)));
            }
            else
                numOfNumsList.Add(dif);
            int more = numOfNum - numOfNumsList.Count;
            for (int i = 0; i < more; i++)
            {
                numOfNumsList.Add(RandomNumber((max / 10), max));
            }
            Shuffle(numOfNumsList);
            return numOfNumsList;

        }

        /*
        The sub-function Shuffle rearrange randomly the list with the numbers.
        list - list of integers.
        */
        protected void Shuffle(List<int> list)
        {
            Random rnd = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /*
        The sub-function allPosSums getting all possible sums in the list.
        list - a list of integers.
        The sub-function returns a list with all possible sums.
        */
        protected List<int> allPosSums(List<int> list)
        {
            List<int> sums = new List<int>();
            List<int> tmp = new List<int>();
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        tmp.Add(list[j]);
                    }
                }
                sums.Add(tmp.Sum());
                tmp.Clear();
            }
            return sums;
        }

        /*
        The sub-function checkingSums checks if there are common sums in 2 lists
        list1 - first integer list.
        list2 - second integer list.
        targetNumber - the sum that is not included in the checking.
        Checking if there are more possible sums in the range of the dictionary and returns a boolean answer.
        */
        protected bool checkingSums(List<int> list1, List<int> list2, int targetNumber)
        {
            int min, max, i = 0;
            min = dictionary.getFirstCode();
            max = dictionary.getLastCode();
            List<int> tmp = new List<int>();
            List<int> allPosSum1 = new List<int>();
            List<int> allPosSum2 = new List<int>();
            allPosSum1 = allPosSums(list1);
            allPosSum2 = allPosSums(list2);
            while (i < allPosSum1.Count)
            {
                if (allPosSum1[i] >= min && allPosSum1[i] <= max && allPosSum1[i] != targetNumber && allPosSum2.Contains(allPosSum1[i]))
                {
                    tmp.Add(allPosSum1[i]);
                }
                i++;
            }
            if (tmp.Count == 0)
                return false;
            return true;
        }

       

        /*
        The sub-function createEncrypeFile write the encrypted data to a new file which it creates.
        list - List<int> that written in to the file.
        */
        protected void createEncrypeFile(List<int> list)
        {
            string file = Path.GetFileNameWithoutExtension(path);
            string efPath = path.Replace(file, file + "-Encrypted");
            string zero;
            int count;
            foreach (int num in list)
            {
                count = 0;
                zero = "";
                if (num < max / 10)
                {
                    int temp = num;
                    while (temp > 0)
                    {
                        temp = temp / 10;
                        count++;
                    }
                    for (int i = 0; i < (numOfdigits - count); i++)
                        zero += "0";
                }


                File.AppendAllText(efPath, (zero + num));

            }
        }

        /*
        The sub-function IntPow calculate pow for intgers and return result.
        x - intger base.
        pow - intger power.
        */
        private int IntPow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }
    }
}
