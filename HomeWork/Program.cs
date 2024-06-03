using HomeWork.Models;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

Cat cat1 = new Cat("nickname1",2,"male",10);
Cat cat2 = new Cat("nickname2",3,"female",12);
Cat cat3 = new Cat("nickname3",1,"female",14);
Cat cat4 = new Cat("nickname4",1,"male",14);
Cat cat5 = new Cat("nickname5",3,"male",11);
Cat cat6 = new Cat("nickname6",2,"female",9);

CatHouse House1 = new CatHouse();
CatHouse House2 = new CatHouse();

PetShop Shop1 = new PetShop();  

House1.AddCat(ref cat1);
House1.AddCat(ref cat4);
House1.AddCat(ref cat6);

House2.AddCat(ref cat2);
House2.AddCat(ref cat3);
House2.AddCat(ref cat5);

Shop1.AddCatHouse(ref House2);
Shop1.AddCatHouse(ref House1);

while (true)
{
    Console.Clear();

    Console.WriteLine("Welcome to the PetShop");

    Console.WriteLine();

    Console.WriteLine("Cat Houses :");

    Console.WriteLine();

    for (int i = 0; i < Shop1.CatHouseCount; i++)
    {
        Console.WriteLine($"{i + 1}.CatHouse");
    }

    Console.WriteLine();

    Console.Write("Hansi cat house-a baxmaq isteyirsiniz :");

    int option = Convert.ToInt32(Console.ReadLine());

    option -= 1;

    Console.Clear();

    Shop1.CatHouses[option].ShowInfo();

    Console.Write("Pisiyin nomresini daxil edin : ");

    int option_cat = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    Actions:

    Console.Clear();

    Console.WriteLine("0.Exit");
    Console.WriteLine("1.Eat");
    Console.WriteLine("2.Sleep");
    Console.WriteLine("3.Play");

    int option_action = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (option_action)
    {
        case 0:
            break;
        case 1:
            Shop1?.CatHouses[option]?.Cats[option_cat].Eat();
            goto Actions;
            break;
        case 2:
            Shop1?.CatHouses[option]?.Cats[option_cat].Sleep();
            goto Actions;
            break;
        case 3:
            Shop1?.CatHouses[option]?.Cats[option_cat].Play();
            goto Actions;
            break;
        default:
            goto Actions;
            break;
    }

    Thread.Sleep(2000);
}






