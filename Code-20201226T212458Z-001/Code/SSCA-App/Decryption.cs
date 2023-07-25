using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCA_App
{
    class Decryption
    {
        private Dictionary dictionary;
        private int subSetAmount; //The key n=3
        private int numOfNum; //The key m=4
        private int numOfdigits; //The key d=2
        private string path;
        StreamReader reader;


        public Decryption(Dictionary newDictionary, int newSubSetAmount, int newNumofNum, int newNumofDigits, string newPath)
        {
            dictionary = new Dictionary(newDictionary);
            subSetAmount = newSubSetAmount;
            numOfNum = newNumofNum;
            numOfdigits = newNumofDigits;
            path = newPath;
            reader = new StreamReader(path);
        }


        public void translation()
        {
            string file = Path.GetFileNameWithoutExtension(path);
            string efPath = path.Replace(file, file + "-Decrypted");
            List<int> fullset = fullSet();
            char c;
            foreach (int i in fullset)
            {
                c = dictionary.searchByCode(i);
                File.AppendAllText(efPath, "" + c);
            }
        }



        public List<int> fullSet()
        {
            List<int> fullSet = new List<int>();
            while (reader.Peek() >= 0)
            {
                fullSet.Add(findCode());
            }
            return fullSet;
        }




        public List<int> getSet()
        {
            int num, i, j, loc = (int)Math.Pow(10, numOfdigits);
            List<int> set = new List<int>();

            for (i = 1; i <= numOfNum; i++)
            {
                num = 0;
                for (j = 1; j < numOfdigits; j++)
                    num += ((reader.Read() - '0') * loc / (j * 10));
                num += (reader.Read() - '0');
                set.Add(num);
                //Console.Write(" " + num);
            }
            return set;
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


        public int findCode()
        {
            int min, max, i, check, counter;
            min = dictionary.getFirstCode();
            max = dictionary.getLastCode();
            List<int> tmp = new List<int>();
            List<int> first = new List<int>();
            List<int> allAther = new List<int>();
            List<int> allPosSumfirst = new List<int>();
            List<int> comper = new List<int>();

            first = getSet();
            allPosSumfirst = allPosSums(first);
            for (int j = 1; j < subSetAmount; j++)
            {
                allAther = getSet();
                comper = allPosSums(allAther);
                i = 0;
                while (i < allPosSumfirst.Count)
                {
                    if (allPosSumfirst[i] >= min && allPosSumfirst[i] <= max && comper.Contains(allPosSumfirst[i]))
                    {
                        tmp.Add(allPosSumfirst[i]);
                    }
                    i++;
                }
            }

            return tmp[0];

        }


    }
}

