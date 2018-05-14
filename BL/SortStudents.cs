using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SortStudents
    {

        public string Name { get; set; }
        private List<Student> students;
        public List<Student> Students { get { return students; } }

        public SortStudents(string name)
        {
            Name = name;
        }

        public string SearchFive()
        {
            FileWork ClassPut = new FileWork(Name);

            string[] ArrFile = ClassPut.ReadAndConvertToArr();
            students = new List<Student>();
            char delimiter = ' ';
            for (int j = 0; j < ArrFile.Length; j++)
            {
                string[] arr = ArrFile[j].Split(delimiter);
                string Name, Date, Year, Group;
                Name = arr[0] + ' ' + arr[1] + ' ' + arr[2];
                Date = arr[3];
                double MedM;
                if (!(Double.TryParse(arr[4], out MedM))) { return "Файл не может быть создан"; }
                Year = arr[5];
                Group = arr[6];
                students.Add(new Student(Name, Date, MedM, Year, Group));
            }

            int[] index = SearchMax(students);
            string str = "";
            for (int j = 0; j < 5; j++)
                str += students[index[j]].Name + ' ' + students[index[j]].Date + ' '
                    + students[index[j]].MedM + ' ' + students[index[j]].Year + ' '
                    + students[index[j]].Group + Environment.NewLine;

            int i = Name.LastIndexOf('.');
            string New = Name.Substring(0, i) + "(better)" + Name.Substring(i);
            ClassPut.CreateStudents(str, New);
            return New;
        }

        private int[] SearchMax(List<Student> students)
        {
            int[] index = new int[5];
            for (int i = 0; i < 5; i++) index[i] = i;
            for (int i = 1; i < 5; i++)
                for (int j = 4; j >= i; j--)
                    if (index[j - 1] > index[j])
                    {
                        int t = index[j - 1];
                        index[j - 1] = index[j];
                        index[j] = t;
                    }

            for (int i = 5; i < students.Count; i++)
            if (students[i].MedM > students[index[4]].MedM)
            if (students[i].MedM > students[index[3]].MedM)
            if (students[i].MedM > students[index[2]].MedM)
            if (students[i].MedM > students[index[1]].MedM)
            if (students[i].MedM > students[index[0]].MedM)
            index[0] = i;
            else index[1] = i;
            else index[2] = i;
            else index[3] = i;
            else index[4] = i;
            return index;
        }
    }
}

