using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Cypher
{
    class Code
    {
        string reader;
        public Code() 
        {
            Menu();
        }

        void Menu()
        {
            Clear();
            WriteLine("Welcome. The Code Breaker");
            WriteLine("What would you like to do?");
            WriteLine("1 Encode 2 Decode");
            reader = ReadLine();
            switch (reader)
            {
                case "1":
                    Encriptor();
                    break;
                case "2":
                    Decriptor();
                    break;
            }
        }

        void Encriptor()
        {            
            string input;
            WriteLine("What is the code that you wish to encrypt?");
            WriteLine("WARNING: ALL CODES WILL BE TURNED LOWERCASE");
            input = ReadLine().ToLower();
            WriteLine(Encrypting(input));
            ReadKey(true);
            Menu();
        }
        string Encrypting(string code)
        {
            string AlphaIn = "abcdefghijklmnopqrstuvwxyz";
            string AlphaOut = "hijklmnopqrstuvwxyzabcdefg";
            int index = 0;
            int refdex = 0;
            char replacement ='z';
            string Encryption = "";
            foreach (char c in code)
            {
                index = 0;
                refdex = 0;
                foreach(char r in AlphaIn)
                {
                    
                    if(c == r)
                    {
                        break;
                    }
                    index ++;
                }
                foreach(char u in AlphaOut)
                {
                    
                    if (index == refdex)
                    {
                        replacement = u;
                    }
                    refdex++;
                }
                Encryption += replacement;
            }
            return (Encryption);
        }
        void Decriptor()
        {
            string input;
            WriteLine("What is the code that you would like decrypted?");
            WriteLine("WARNING: ALL CODES WILL BE TURNED LOWERCASE");
            input = ReadLine().ToLower();
            WriteLine(Decrypting(input));
            ReadKey(true);
            Menu();
        }
        string Decrypting(string code)
        {
            string AlphaOut = "abcdefghijklmnopqrstuvwxyz";
            string AlphaIn = "hijklmnopqrstuvwxyzabcdefg";
            int index = 0;
            int refdex = 0;
            char replacement = 'z';
            string Encryption = "";
            foreach (char c in code)
            {
                index = 0;
                refdex = 0;
                foreach (char r in AlphaIn)
                {

                    if (c == r)
                    {
                        break;
                    }
                    index++;
                }
                foreach (char u in AlphaOut)
                {

                    if (index == refdex)
                    {
                        replacement = u;
                    }
                    refdex++;
                }
                Encryption += replacement;
            }
            return (Encryption);
        }
    }
}
