using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTime
{
    class Time
    {
        private int ore, minute, secunde, sutimi;

        public Time(int ore, int minute, int secunde = 0, int sutimi = 0)
        {
            this.ore = ore;
            this.minute = minute;
            this.secunde = secunde;
            this.sutimi = sutimi;
        }
        public Time(string timp)
        {
            string[] timps = timp.Split(':');
            if (timps.Length != 4)
            {
                Console.WriteLine("Format timp incorect");
                return;
            }
            this.ore = int.Parse(timps[0]);
            this.minute = int.Parse(timps[1]);
            this.secunde = int.Parse(timps[2]);
            this.sutimi = int.Parse(timps[3]);
        }
        public static Time operator +(Time t1, Time t2)
        {
            Time t = new Time(0, 0, 0, 0);
            int k;
            t.sutimi = (t1.sutimi + t2.sutimi) % 100;
            k = (t1.sutimi + t2.sutimi) / 100;
            t.secunde = (t1.secunde + t2.secunde + k) % 60;
            k = (t1.secunde + t2.secunde + k) / 60;
            t.minute = (t1.minute + t2.minute + k) % 60;
            k = (t1.minute + t2.minute + k) / 60;
            t.ore = t1.ore + t2.ore + k;
            return t;
        }
        public static Time operator -(Time t1, Time t2)
        {
            Time t = new Time(0, 0, 0, 0);
            int k;
            t.sutimi = (t1.sutimi - t2.sutimi) % 100;
            k = (t1.sutimi - t2.sutimi) / 100;
            if (t.sutimi < 0)
            {
                t.sutimi = t.sutimi + 100;
                k = k + 1;
            }
            t.secunde = (t1.secunde - t2.secunde - k) % 60;
            k = (t1.secunde - t2.secunde - k) / 60;
            if (t.secunde < 0)
            {
                t.secunde = t.secunde + 60;
                k = k + 1;
            }
            t.minute = (t1.minute - t2.minute - k) % 60;
            k = (t1.minute - t2.minute - k) / 60;
            if (t.minute < 0)
            {
                t.minute = t.minute + 60;
                k = k + 1;
            }
            t.ore = t1.ore - t2.ore - k;
            return t;
        }
        public static bool operator ==(Time t1, Time t2)
        {
            if ((t1.ore == t2.ore) && (t1.minute == t2.minute) && (t1.secunde == t2.secunde) && (t1.sutimi == t2.sutimi))
                return true;
            return false;
        }
        public static bool operator !=(Time t1, Time t2)
        {
            if (t1 == t2)
                return false;
            return true;
        }
        public static bool operator <(Time t1, Time t2)
        {
            if (t1.ore < t2.ore)
                return true;
            if ((t1.ore == t2.ore) && (t1.minute < t2.minute))
                return true;
            if ((t1.ore == t2.ore) && (t1.minute == t2.minute) && (t1.secunde < t2.secunde))
                return true;
            if ((t1.ore == t2.ore) && (t1.minute == t2.minute) && (t1.secunde < t2.secunde) && (t1.sutimi < t2.sutimi))
                return true;
            return false;
        }
        public static bool operator <=(Time t1, Time t2)
        {
            if (t1 < t2 || t1 == t2)
                return true;
            return false;
        }
        public static bool operator >(Time t1, Time t2)
        {
            if (t1 <= t2)
                return false;
            return true;
        }
        public static bool operator >=(Time t1, Time t2)
        {
            if (t1 < t2)
                return false;
            return true;
        }
        public string afisare()
        {
            return $"{this.ore}:{this.minute}:{this.secunde}:{this.sutimi}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Să se creeze un tip de date definit de utilizator numit Time pentru reprezentarea timpului sub forma (ore : minute : secunde : sutimi). Pentru acest tip de date să se implementeze operațiile de adunare a doi timpi, respectiv de scădere, precum și operatorii relaționali. Se vor utiliza patru modalități de inițializare a unui obiect de tip Time, și anume: Time(ore, minute), Time(ore, minute, secunde), Time(ore, minute, secunde, sutimi) și Time(”ore:minute:secunde:sutimi”).
            //Ex. (10:30:25:75) + (47:50:40:60) = (58:21:6:35)
            Time t1 = CitireTimp();
            Time t2 = CitireTimp();
            Time suma = t1 + t2;
            afisareOperatie(t1, t2, "+",suma);
            Time diferenta = t1 - t2;
            afisareOperatie(t1, t2, "-", diferenta);
            afisareOperatori(t1,t2);
        }
        public static void afisareOperatie(Time t1, Time t2,string operatie,Time rezultat)
        {
            Console.WriteLine($"({t1.afisare()}) {operatie} ({t2.afisare()}) = ({rezultat.afisare()}) ");
        }
        public static Time CitireTimp()
        {
            int ore=0,minute=0,secunde=0,sutimi=0;
            Console.WriteLine("Timp : ");
            Console.Write("ore=");
            ore = int.Parse(Console.ReadLine());
            Console.Write("minute=");
            minute = int.Parse(Console.ReadLine());
            Console.Write("secunde=");
            secunde = int.Parse(Console.ReadLine());
            Console.Write("sutimi=");
            sutimi = int.Parse(Console.ReadLine());
            return new Time(ore, minute, secunde, sutimi);
        }
        public static void afisareOperatori(Time t1, Time t2)
        {
            if (t1 == t2)
                Console.WriteLine("Timpii coincid");
            else
                if (t1 < t2)
                Console.WriteLine("Timpul 1 este anterior Timpului 2");
            else
                Console.WriteLine("Timpul 2 este anterior Timpului 1");
        }
    }

}