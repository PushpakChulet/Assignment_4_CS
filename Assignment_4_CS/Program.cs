using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_CS
{
    class Plural
    {
        public void Pluralword(string word)
        {

            int length = word.Length;
            char[] w = word.ToCharArray();

            if (w[length - 1] == 'y')
            {

                w[length - 1] = 'i';
                w[length] = 'e';
                w[length + 1] = 's';
                w[length + 2] = '\0';
            }

            else if (w[length - 1] == 's' ||
                   (w[length - 2] == 'c' && w[length - 1] == 'h') ||
                   (w[length - 2] == 's' && w[length - 1] == 'h'))
            {

                word += "es";
            }

            else
            {
                word += "s";
            }

            Console.WriteLine(word);

            return;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var words = new List<string>() {"Boat", "house", "cat", "river", "cupboard"};

            Plural pr = new Plural();

            //Plurals of list items
            foreach (var str in words)
                pr.Pluralword(str);

            words[words.FindIndex(ind => ind.Equals("house"))] = "Home";

            Console.WriteLine();
            pr.Pluralword(words[1]);

            words.Add("Started");
            words.Add("with");
            words.Add("the");
            words.Add("big");
            words.Add("bang");


            Console.WriteLine();
            Console.WriteLine(words.Count);
            Console.WriteLine();
            foreach (var variab in words)
            {
                if (variab.Length == 7)
                    Console.WriteLine(variab);
            }

            Console.WriteLine();
            Console.WriteLine(words[2]);
            Console.WriteLine();

            words.Sort();
            foreach (var r in words)
                Console.WriteLine(r);

            Console.WriteLine();
            words.Reverse();
            foreach (var reverse in words)
                Console.WriteLine(reverse);
        }
    }
}
