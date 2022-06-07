using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoubleSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\solutionsForSpaceApp\\2027\\input.txt";
            string outputpath = "D:\\solutionsForSpaceApp\\2027\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            string a;
            string secondLine;
            string thirdLine;
            string fourthLine;
            using (var readera = new StreamReader(inputpath))
            {
                a = readera.ReadLine();
                secondLine = readera.ReadLine();
                thirdLine = readera.ReadLine();
                fourthLine = readera.ReadLine();
            };

            int[] A;
            A = new int[Convert.ToInt32(a)];

            //вытаскиваю вторую строку и заполняю массив
            string[] lineForInt = secondLine.Split(' ');
            int counter = 0;
            foreach (var s in lineForInt)
            {
                A[counter++] = (Convert.ToInt32(s));
            }



            List<int> forBorders = new List<int>();
            lineForInt = thirdLine.Split(' ');
            foreach (var s in lineForInt)
            {
                forBorders.Add(Convert.ToInt32(s));
            }

            lineForInt = fourthLine.Split(' ');
            foreach(var s in lineForInt)
            {
                forBorders.Add(Convert.ToInt32(s));
            }

            int l1 = forBorders[0]-1, r1 = forBorders[1]-1, l2 = forBorders[2]-1, r2 = forBorders[3]-1;





            int lengthFoFirstReverse = r1 - l1+1;

            Array.Reverse(A, l1, lengthFoFirstReverse);

            int lengthFoSecondReverse = r2 - l2+1;

            Array.Reverse(A, l2, lengthFoSecondReverse);



            string outputstring = "";
            for (int i = 0; i < A.Length; i++)
            {
                outputstring = outputstring + A[i] + ' ';
            }

            File.WriteAllText(outputpath, outputstring);

        }
        
    }
}