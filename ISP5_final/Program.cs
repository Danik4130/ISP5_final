using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ISP5_final {
   class Program
   {
        static void Main(string[] args)
        {
            Console.Write("Ввесите имя персонажа:\t");

            string name;
            name = Console.ReadLine();
            Console.Write("Ввесите возраст персонажа (1-100):\t");
            int ages;
            ages = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите класс персонажа: \n(1)Паладин, (2)Ассассин, (3)Лучник, (4)Маг");
            string tip;
            int job;
            job = int.Parse(Console.ReadLine());
            switch (job){
                case 1:
                    Paladin paladin1 = new Paladin();
                    tip = "Паладин";
                    paladin1.Type = tip;
                    Console.WriteLine("Вы выбрали персонада типа:  " + tip);  
                    paladin1.Name = name;
                    paladin1.Age = ages;
                    Console.WriteLine(paladin1.ShowPers());
                    Console.WriteLine(paladin1.Run());
                    Console.WriteLine(paladin1.TypeOfAttack());
                    Console.WriteLine(paladin1.Stats());
                    Console.WriteLine(paladin1.Specs());
                    Console.WriteLine(paladin1.Perspectives());
                    break;
                case 2:
                    Assassin assassin1 = new Assassin();
                    tip = "Ассассин";
                    assassin1.Type = tip;
                    Console.WriteLine("Вы выбрали персонада типа:  " + tip);
                    assassin1.Name = name;
                    assassin1.Age = ages;
                    Console.WriteLine(assassin1.ShowPers());
                    Console.WriteLine(assassin1.Run());
                    Console.WriteLine(assassin1.TypeOfAttack());
                    Console.WriteLine(assassin1.Stats());
                    Console.WriteLine(assassin1.Specs());
                    Console.WriteLine(assassin1.Perspectives());
                    break;
                case 3:
                    Archer archer1 = new Archer();
                    tip = "Лучник";
                    archer1.Type = tip;
                    Console.WriteLine("Вы выбрали персонада типа:  " + tip);
                    archer1.Name = name;
                    archer1.Age = ages;
                    Console.WriteLine(archer1.ShowPers());
                    Console.WriteLine(archer1.Run());
                    Console.WriteLine(archer1.TypeOfAttack());
                    Console.WriteLine(archer1.Stats());
                    Console.WriteLine(archer1.Specs());
                    Console.WriteLine(archer1.Perspectives());
                    break;
                case 4:
                    Paladin mage1 = new Paladin();
                    tip = "Маг";
                    mage1.Type = tip;
                    Console.WriteLine("Вы выбрали персонада типа:  " + tip);
                    mage1.Name = name;
                    mage1.Age = ages;
                    Console.WriteLine(mage1.ShowPers());
                    Console.WriteLine(mage1.Run());
                    Console.WriteLine(mage1.TypeOfAttack());
                    Console.WriteLine(mage1.Stats());
                    Console.WriteLine(mage1.Specs());
                    Console.WriteLine(mage1.Perspectives());
                    break;
                default:
                    Console.WriteLine("Вы никого не выбрали");
                    break;
            }
            Console.ReadKey();
        }
   }

}