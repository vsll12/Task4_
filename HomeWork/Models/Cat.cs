using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    internal class Cat
    {
        public string Nickname {  get; set; }
        public int Age{ get; set; }
        public string Gender { get; set; }

        public int Energy { get; set;}

        public double Price{ get; set; }

        public int MealQuanity { get; set; }

        public Cat() { }    

        public Cat(string nickname, int age, string gender, double price)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = 100;
            Price = price;
            MealQuanity = 0;
        }

        public void Eat()
        {
            Console.WriteLine("Cat is eating...");
            Energy = Energy == 100 ? 100 : Energy += 10;
            Price += 10;
            MealQuanity += 1;
            Thread.Sleep(1000);
        }

        public void Sleep()
        {
            Console.WriteLine("Cat is sleeping...");
            Energy = 100;
            Thread.Sleep(1000);
        }

        public void Play()
        {
            Console.WriteLine("Cat is playing...");
            Energy -= 10;
            Thread.Sleep(1000);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Nickname} {Gender} {Age} {Price} {Energy} {MealQuanity}");
        }
    }
}
