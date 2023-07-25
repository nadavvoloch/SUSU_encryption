using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCA_App
{
    class Sign
    {
        /*
        The class is for defining a sign in the dictionary.
            original - the original sign
            codeNumber - code in the dictionary
        The class has one constractor which recieve 2 parameters. 
        */
        private char original;
        private int codeNumber;


        public Sign(char newOriginal, int newCodeNumber)
        {
            original = newOriginal;
            codeNumber = newCodeNumber;
        }

        public char getOriginal()
        {
            return original;
        }

        public int getCodeNumber()
        {
            return codeNumber;
        }
    }
}
