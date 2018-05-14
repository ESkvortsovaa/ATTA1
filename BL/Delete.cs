using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Delete
    {
        public string Arr { get; set; }

        public Delete(string arr)
        {
            Arr = arr;
        }
        public void DeleterPositiveOfFile()
        {
            FileWork ClassPut = new FileWork(Arr);
            string[] ArrFile = ClassPut.ReadArrayFromBinaryFile(Arr);
            for (int i = 0; i < ArrFile.Length; i++)
            {
                if (Convert.ToInt32(ArrFile[i]) >= 0)
                {
                    ArrFile[i]="";
                }
            }
            string str = "";
            for (int i = 0; i < ArrFile.Length; i++)
                str += ArrFile[i] + Environment.NewLine;
            ClassPut.WriteArrayToBinaryFile(str);
        }
        public void DeleterNegativeOfFile()
        {
            FileWork ClassPut = new FileWork(Arr);
            string[] ArrFile = ClassPut.ReadArrayFromBinaryFile(Arr);
            for (int i = 0; i < ArrFile.Length; i++)
            {
                if (Convert.ToInt32(ArrFile[i]) <= 0)
                {
                    ArrFile[i] = "";
                }
            }

            string str = "";
            for (int i = 0; i < ArrFile.Length; i++)
                str += ArrFile[i] + Environment.NewLine;
            ClassPut.WriteArrayToBinaryFile(str);
        }
        public void DeleterEvenOfFile()
        {
            FileWork ClassPut = new FileWork(Arr);
            string[] ArrFile = ClassPut.ReadArrayFromBinaryFile(Arr);
            for (int i = 0; i < ArrFile.Length; i++)
            {
                if (Convert.ToInt32(ArrFile[i]) %2==0)
                {
                    ArrFile[i] = "";
                }
            }
            string str = "";
            for (int i = 0; i < ArrFile.Length; i++)
                str += ArrFile[i] + Environment.NewLine;
            ClassPut.WriteArrayToBinaryFile(str);
        }
        public void DeleterOddOfFile()
        {
            FileWork ClassPut = new FileWork(Arr);
            string[] ArrFile = ClassPut.ReadArrayFromBinaryFile(Arr);
            for (int i = 0; i < ArrFile.Length; i++)
            {
                if (Convert.ToInt32(ArrFile[i]) % 2 != 0)
                {
                    ArrFile[i] = "";
                }
            }
            for (int i = 0; i < ArrFile.Length; i++)
            {
                if (Convert.ToString(ArrFile[i]) == " ") { DeleterThisAndMove(ref ArrFile, i); }
            }
            string str = "";
            for (int i = 0; i < ArrFile.Length; i++)
                str += ArrFile[i] + Environment.NewLine;
            ClassPut.WriteArrayToBinaryFile(str);
        }
        private void DeleterThisAndMove(ref string[] ArrFile, int i)
        {
            int j = i;
            while (ArrFile[i] == " ")
                for (j = i; j < ArrFile.Length - 1; j++)
                    ArrFile[j] = ArrFile[j + 1];
            ArrFile[ArrFile.Length - 1] = null;
        }
    }
}
