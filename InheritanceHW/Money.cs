using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    class Money
    {
        public string Currency { get; set; }
        public int Cush { get; set; }
        public int Penni { get; set; }
        public Money()
        {
            Console.Write("Введите валюту -> ");
            Currency = Console.ReadLine();
            Console.Write("Введите количество денег -> ");
            Cush = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество копеек -> ");
            Penni = Convert.ToInt32(Console.ReadLine());
        }
        public Money(string currency, int cush, int penni)
        {
            Currency = currency;
            Cush = cush;
            Penni = penni;
        }
        public void Print()
        {
            Console.WriteLine($"Ваш счет:{Cush}.{Penni} {Currency} ");
        }
    }
    class Product : Money
    {
        public Product(string currency, int cush, int penni) : base(currency, cush, penni)
        { }
        public Product() : base()
        { }

        public Product Plus(int cush, int penni)
        {
            if (Penni >= 100)
            {
                Cush++;
                penni = 0;
            }
            Cush += cush;
            Penni += penni;
            return this;
        }
        public Product Minus(int cush, int penni)
        {
            try
            {
                if (cush >= Cush)
                    throw new Exception("Недостаточно денег");
            }
            catch(Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            Cush -= cush;
            Penni -= penni;
            return this;
        }

    }
}
