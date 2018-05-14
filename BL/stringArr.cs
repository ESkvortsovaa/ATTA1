using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class stringArr
    {
        public string[] Arr { get; set; }

        public stringArr(string[] arr)
        {
            Arr = arr;
        }

       public void Sol(out int sum, out int kol)
        {
            sum = 0;
            kol = 0;
            foreach (string str in Arr)
            {
                //str.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] strArr = str.Split(' ');
                int numb;
                if (Int32.TryParse(str, out numb))
                {
                    sum += numb;
                    kol++;
                }
            }
        }

        public void Sol2(out double sum2, out double kol2)
        {
            sum2 = 0;
            kol2 = 0;
            foreach (string str in Arr)
            {
                string[] strArr = str.Split(' ');
                double numb;
                if (Double.TryParse(str, out numb))
                {
                    sum2 += numb;
                    kol2++;
                }
            }
        }

    }
}
