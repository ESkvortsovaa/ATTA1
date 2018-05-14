using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class FileWork
    {

        public string Way { get; set; }

        public FileWork(string way)
        {
            Way = way;
        }

     /////// 2.1.26
        public string[] ReadArrayFromBinaryFile(string Way)
        {
            FileStream fs = new FileStream(Way, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            long amount = fs.Length / sizeof(double);
            string[] arr = new string[amount];
            for (int i = 0; i < amount; i++)
                arr[i] = br.ReadString();
            br.Close();
            fs.Close();
            return arr;
        }
        public void WriteArrayToBinaryFile(string str)
        {
            FileStream fs = new FileStream(str, FileMode.OpenOrCreate); 
            BinaryWriter bw = new BinaryWriter(fs); 
            for (int i = 0; i < Way.Length; i++)
                bw.Write(Way[i]); 
            bw.Close();
            fs.Close();
        }

        public string[] ReadFile()
        {
            return File.ReadAllLines(Way);
        }
        public string[] ReadAndConvertToArr()
        {
            return File.ReadAllLines(Way, Encoding.Default);
        }
        public void RewriteInFile(string str)
        {
            FileInfo oldFile = new FileInfo(Way);
            oldFile.Delete();
            StreamWriter writer = new StreamWriter(Way);
            writer.Write(str);
            writer.Close();
        }

        ///////3.1.26
        public void CreateStudents(string str, string New)
        {
            FileStream aFile = new FileStream(New, FileMode.Create);
            StreamWriter a = new StreamWriter(aFile);
            a.Write(str);
            a.Close();
            aFile.Close();
        }


        /////1.1.26
        public void SumInt(out int Sum, out int Kol, out double Sum2, out double Kol2)
        {
            string[] arr = ReadFile();
            stringArr str = new stringArr(arr);
            str.Sol(out Sum, out Kol);
            str.Sol2(out Sum2, out Kol2);
            Kol2 -= Kol;
            Sum2 -= Sum;
        }     

    }
}
