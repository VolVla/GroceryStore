using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    internal class Program
    {
        static void Main()
        {
            Store store = new Store();
            ConsoleKey exitButton = ConsoleKey.Enter;
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Для начало работы нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
                store.CortOverdueCannedFood();
                Console.WriteLine($"\nВы хотите выйти из программы?Нажмите {exitButton}.\nДля продолжение работы нажмите любую другую клавишу");

                if (Console.ReadKey().Key == exitButton)
                {
                    Console.WriteLine("Вы вышли из программы");
                    isWork = false;
                }

                Console.Clear();
            }
        }
    }

    class Store
    {
        private List<CannedFood> _cannedFoodList;
       public Store() 
       {
            _cannedFoodList = new List<CannedFood>()
            {
                new CannedFood("Alenushka ", 600,80),
                new CannedFood( "Topor", 20,50),
                new CannedFood( "Neptyn", 35,75),
                new CannedFood( "FishandShip",  233,20),
                new CannedFood( "TapTar", 5323,90),
                new CannedFood( "MilkD", 10000,100),
                new CannedFood( "Azetoy", 310,32),
                new CannedFood( "ColaToka", 270,85),
                new CannedFood( "TamTam", 110,52),
                new CannedFood( "ZetZam", 48,20),
            };
       }

       public void CortOverdueCannedFood()
       {

       }
    }

    class CannedFood
    {
        public CannedFood(string name,int productionDate,int shelfLife) 
        {
            Name = name;
            ProductionDate = productionDate;
            ShelfLife = shelfLife;
        }

        public string Name { get;private set; }
        public int ProductionDate { get; private set; }
        public int ShelfLife { get; private set; }
    }
}
