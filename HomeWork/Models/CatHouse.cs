using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    internal class CatHouse
    {
        public Cat[]? Cats;
        public int CatCount { get; set; }

        public void AddCat(ref Cat cat)
        {

            if (Cats?.Length > 0)
            {
                Cat[] Cats_temp = new Cat[Cats.Length + 1];
                for (int i = 0; i < Cats.Length; i++)
                {
                    Cats_temp[i] = Cats[i];
                }
                Cats_temp[Cats.Length] = cat;
                Cats = Cats_temp;
            }
            else
            {
                Cats = new Cat[1];
                Cats[0] = cat;
            }
        }

        public void RemoveByNickname(string nickname)
        {
        if (Cats?.Length > 0)
        {
            int index = 0;
            Cat[] Cats_temp = new Cat[Cats.Length - 1 ];
            for (int i = 0; i < Cats.Length; i++)
            {
                    if (Cats[i].Nickname != nickname)
                    {
                        Cats_temp[index] = Cats[i];
                        index += 1;
                    }
            }
            Cats = Cats_temp;
        }
        else
        {
                throw new Exception();
        }
        }

        public void ShowInfo()
        {
            for (int i = 0; i < Cats?.Length; i++)
            {
                Console.Write($"{i + 1}.");
                Cats[i].ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
