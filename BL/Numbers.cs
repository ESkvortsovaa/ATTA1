using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace BL
{
    public class Numbers
    {
       

        public string B { get; set; }
        public Numbers(string b)
        {
           B = b;
        }

        /*public string[] FileTextToMasConverter()
        {
            string[] textStrings = File.ReadAllLines(B, Encoding.Default);
            string[] words = B.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return textStrings;

        }

      /* public void StringUtility()
        {
            string[] textStrings = FileTextToMasConverter();
            for (int i = 0; i < textStrings.Length; i++)
            {
                string[] words = textStrings[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                textStrings[i] = string.Join(" ", words);
            }
            FileOutput(textStrings);
        }

        public void FileOutput(string[] textStrings)
        {

            StreamWriter file = new StreamWriter(B, false);
            foreach (string element in textStrings)
            {
                file.WriteLine(element);
            }
            file.Close();
        }*/
        
        

        public int FindSummaForInt()
        {
            int sum1 = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (!B[i].ToString().Contains("."))
                {
                    sum1 += Convert.ToInt32(B[i]);
                }
            }
            return sum1;
        }
       
        public double FindSummaForDoubl()
        {
            double sum2 = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i].ToString().Contains("."))
                {
                    sum2 += Convert.ToDouble(B[i]);
                }
            }
            return sum2;
        }
        public int FindCountForDoubl()
        {
            int kol2 = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i].ToString().Contains("."))
                {
                    kol2++;
                }
            }
            return kol2;
        }
        public int FindCountForInt()
        {

            int kol1 = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (!B[i].ToString().Contains("."))
                {
                    kol1++;
                }
            }
            return kol1;
        }

    }
}
