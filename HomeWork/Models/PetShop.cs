using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    internal class PetShop
    {
       public CatHouse[] CatHouses;

        public int CatHouseCount { get; set; }

        public PetShop() { }

        public void AddCatHouse(ref CatHouse CatHouse)
        {

            if (CatHouses?.Length > 0)
            {
                CatHouse[] CatHouses_temp = new CatHouse[CatHouses.Length + 1];
                for (int i = 0; i < CatHouses.Length; i++)
                {
                    CatHouses_temp[i] = CatHouses[i];
                }
                CatHouses_temp[CatHouses.Length] = CatHouse;
                CatHouses = CatHouses_temp;
                CatHouseCount += 1;
            }
            else
            {
                CatHouses = new CatHouse[1];
                CatHouses[0] = CatHouse;
                CatHouseCount += 1;
            }
            
        }

        public void ShowInfo()
        {
            for (int i = 0;i < CatHouses.Length;i++) {
                Console.Write($"{i + 1}.");
                CatHouses[i].ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
