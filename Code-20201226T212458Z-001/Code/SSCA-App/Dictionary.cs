using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCA_App
{
    /*
    The class is for defining a dictionary.
    dictionary - a list of Signs
    The class has empty constractor and a copy constractor.
    */
    public class Dictionary
    {
        private List<Sign> dictionary;


        public Dictionary()
        {
            dictionary = new List<Sign>();
        }

        public Dictionary(Dictionary previousDictionary)
        {
            dictionary = new List<Sign>();
            foreach (Sign element in previousDictionary.dictionary)
            {
                this.push(element.getOriginal(), element.getCodeNumber());
            }
        }

        /*
        The function adds new sign to the dictionary.
        */
        public void push(char original, int codeNumber)
        {
            Sign newSign = new Sign(original, codeNumber);
            dictionary.Add(newSign);
        }

        /*
        The function clears the dictionary.
        */
        public void clear()
        {
            dictionary.Clear();
        }

        /*
        The method searchByCode gets codeNumber and return the original char.
        Return '0' if Sign is not found.
        */
        public char searchByCode(int codenumber)
        {
            Sign check;
            check = dictionary.Find(x => x.getCodeNumber().Equals(codenumber));
            if (check == null)
                return '0';
            return check.getOriginal();
        }

        /*
        The method searchByOriginal gets the original char and return the codeNumber.
        Return -1 if Sign is not found.
        */
        public int searchByOriginal(char original)
        {
            Sign check;
            check = dictionary.Find(x => x.getOriginal().Equals(original));
            if (check == null)
                return -1;
            return check.getCodeNumber();
        }

        /*
        Dynamically load the dictionary according the text language
        */
        public void loadDictionary() // Need to adjust to external file
        {
            for (int i = 0; i < 26; i++)
            {
                this.push((char)(97 + i), (101 + i)); //a-z
            }
            this.push((char)32, 127); //space
            this.push((char)10, 128); // \n
            this.push((char)13, 129); // \r
            this.push((char)44, 130); //,
            this.push((char)46, 131); //.
            //for (int i = 0; i < 26; i++)
            //{
            //    this.push((char)(97 + i), (10011 + i)); //a-z
            //}
            //this.push((char)32, 10027); //space
            //this.push((char)10, 10028); // \n
            //this.push((char)13, 10029); // \r
            //this.push((char)44, 10030); //,
            //this.push((char)46, 10031); //.
        }

        /*
        The function getFirstCode returns the first code number in the dictionary.
        */
        public int getFirstCode()
        {
            return dictionary.First().getCodeNumber();
        }

        /*
        The function getLastCode returns the last code number in the dictionary.
        */
        public int getLastCode()
        {
            return dictionary.Last().getCodeNumber();
        }
    }
}
