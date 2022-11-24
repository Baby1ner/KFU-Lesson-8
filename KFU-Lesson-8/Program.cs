using System;
using System.Collections.Generic;

namespace KFU_Lesson_8
{

    public class Person
    {
        public string name { get; set; }
        public string position { get; set; }
        public Person boss { get; set; }
        public Person(string name,string position, Person boss)
        {
            this.name = name;
            this.position = position;
            this.boss = boss;
        }
        public Person(string name, string position)
        {
            this.name = name;
            this.position = position;
        }


    }
    

    internal class Program
    {
        static void otvet(string name1,string name2, string zadach, List<Person> people)
        {
            Console.WriteLine($"От {name1} дается задача {zadach}, человеку {name2} ");
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].name == name2)
                {
                    if (people[i].boss.name == name1 ) Console.WriteLine("Он будет ее делать");
                    else Console.WriteLine("Он не будет ее делать");
                }
            }
        }

        static void Main(string[] args)
        {
            var Borisg = new Person("Борис","Начальство");
            var Rashid = new Person("Рашид", "Начальство", Borisg);
            var Lucas = new Person("Лукас", "Начальство", Rashid);
            var Ilham = new Person("Ильхам", "Начальство", Borisg);
            var Orcadi = new Person("Оркадий", "Начальство", Ilham);
            var Voloidya = new Person("Володя", "Начальство", Orcadi);
            List<Person> nachalnik = new List<Person>() { Borisg, Rashid , Lucas , Ilham , Orcadi , Voloidya };
            var Ilshat = new Person("Ильшат", "Системщик", Voloidya);
            var Ivanich = new Person("Иваныч", "Системщик", Ilshat);
            var Ilya = new Person("Илья", "Системщик", Ivanich);
            var Vitya = new Person("Витя", "Системщик", Ivanich);
            var Zhenia = new Person("Женя","Системщик", Ivanich);
            List<Person> system = new List<Person>() { Ilshat, Ivanich, Ilya, Vitya, Zhenia };
            var Sergei = new Person("Сергей", "Разработчик", Voloidya);
            var Leysan = new Person("Ляйсан","Разработчик", Sergei);
            var Marat = new Person("Марат", "Разработчик", Leysan);
            var Dina = new Person("Дина", "Разработчик", Leysan);
            var Ildar = new Person("Ильдар", "Разработчик", Leysan);
            var Anton = new Person("Антон","Разработчик", Leysan);
            List<Person> razrab = new List<Person>() { Sergei, Leysan, Marat, Dina , Ildar , Anton ,};

            for (int i=0; i < 5; i++)
            {
                Console.WriteLine("Введите Задачу");
                string zadanie = Console.ReadLine();
                Console.WriteLine("Кто должен решить эту задачу?(Системщик,Разработчик,Начальство)");
                string who = Console.ReadLine();
                Console.WriteLine("От кого Задача?");
                string name1 = Console.ReadLine();
                Console.WriteLine("Кому задача ?");
                string name2 = Console.ReadLine();
                switch (who)
                {
                    case "Системщик":
                        otvet(name1, name2, zadanie, system);
                        break;
                    case "Разработчик":
                        otvet(name1, name2, zadanie, razrab);
                        break;
                    case "Начальство":
                        otvet(name1, name2, zadanie, nachalnik);
                        break;
                        default:
                        Console.WriteLine("У нас нет такого типа сотрудников ");
                        break;
                }
            }
        }
    }
}
