using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Bank
    {
        public enum tip
        {
            current,
            saving
        }
        private int Id = 0;
        private int Balans;
        private tip Type;
        private static int Idk;

        public Bank(int Balans, tip Type)
        {
            Idk++;
            Id = Idk;
            this.Balans = Balans;
            this.Type = Type;
        }
        public void Takeoff()
        {
            Console.WriteLine("Введите сумму, которую хотите снять");
            int off = int.Parse(Console.ReadLine());
            if (Balans > off)
            {
                Balans -= off;
            }
            else
            {
                Console.WriteLine("Неправильно попробуй еще раз");
                Takeoff();
            }
        }
        public void Takeon()
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            int on = int.Parse(Console.ReadLine());
            Balans += on;
        }
        public void transfer(Bank Bank, int sum)
        {
            if (Balans > sum)
            {
                Balans -= sum;
                Bank.Balans += sum;
            }
            else Console.WriteLine("Не хватает денег для перевода");
        }
        public void Print()
        {
            Console.WriteLine($"Номер = {Id}, Тип: {Type}, Баланс: {Balans}");
        }
    }
}
