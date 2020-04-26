using System;
using System.IO;

namespace OOP_lab_3_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("file.txt");

            string str = fromFile.ReadLine();

            fromFile.Close();

            string[] decimals = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            int counter = 0;

            int[] a = new int[decimals.Length];

            foreach (string _decimal in decimals)
            {
                if (Int32.TryParse(_decimal, out a[index]))
                {
                    ++index;
                }
            }

            int[] b = new int[a.Length * 2];

            index = 0;

            for (int i = 0; i < a.Length; ++i)
            {
                b[index] = a[i];

                if ((i % 2 == 0) && (a[i] % 2 == 0))
                {
                    ++index;
                
                   b[index] = a[i];
                }
                
                ++index;
            }

            StreamWriter toFile = new StreamWriter("file.txt");
            
            for (int i = 0; i < index; ++i)
            {
                toFile.Write("{0} ", b[i]);
            }

            toFile.Close();
        }
    }
}
