using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Remoting.Lifetime;

namespace T00Much
{
    internal class Program
    {

        static string Tusk2(string lena)
        {
            string str = "" ;
            for (int i = lena.Length - 1; i >= 0; i--)
                str = str + lena[i];
            return str;
        }




        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1");
            Bank bank1 = new Bank(120,Bank.tip.current);
            Bank bank2 = new Bank(250,Bank.tip.saving);
            bank1.Print();
            bank2.Print();
            bank1.transfer(bank2, 30);
            bank1.Print();
            bank2.Print();
            

            Console.WriteLine("Задание 2");
            string str = Tusk2("123456789");
            Console.WriteLine(str);
            
            

            Console.WriteLine("Задание 3 \nВведите имя файла");
            string inputFileName = Console.ReadLine();
            StreamWriter sw = new StreamWriter(inputFileName);
            if (File.Exists(inputFileName))
            {
                Console.WriteLine("Найден файл с таким именем, напишите что вы хотите туда добавить");
                string outputFileName = Console.ReadLine();
                sw.WriteLine(outputFileName);
                sw.Close();
                Console.WriteLine("Результат успешно записан ");
            }
            else Console.WriteLine("Файл с таким именем не найден");
            



            Console.WriteLine("Домашнее задание 1");
            List<string> fileLines = File.ReadAllLines("C:\\Users\\User\\source\\repos\\KFU-Lesson-8\\T00Much\\TextFile2.txt").ToList();
            foreach (var fileLine in fileLines)
            {
                var splitFileLine = fileLine.Split(new[] { " # " }, StringSplitOptions.None);

                string fio = splitFileLine[0];
                string mail = splitFileLine[1];
                using (var str1 = new StreamWriter("C:\\Users\\User\\source\\repos\\KFU-Lesson-8\\T00Much\\TextFile3.txt", true))
                {
                    str1.WriteLine(mail);
                }
            }
            




            Console.WriteLine("Домашнее задание 2");
            Song song1 = new Song();
            Song song2 = new Song();
            Song song3 = new Song();
            Song song4 = new Song();
            List<Song> list = new List<Song>() { song1, song2, song3, song4 };
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Name();
                list[i].Autor();
                if (i != 0)
                {
                    list[i].prev = list[i - 1];
                }
                list[i].Title();

            }

            if (list[1].Equals(list[0])) Console.WriteLine("Это одна песня");
            else Console.WriteLine("Это разные песни");


        }
    }
}
