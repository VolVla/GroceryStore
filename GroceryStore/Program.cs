using System;
using System.Collections.Generic;
using System.Linq;

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
        private DateTime _date = new DateTime(2023, 9, 11);

        public Store()
        {
            _cannedFoodList = new List<CannedFood>()
            {
                new CannedFood("Alenushka ", 1999,5),
                new CannedFood( "Topor", 1995,6),
                new CannedFood( "Neptyn", 2012,2),
                new CannedFood( "FishandShip",  1999,3),
                new CannedFood( "TapTar", 2007,4),
                new CannedFood( "MilkD", 2022,7),
                new CannedFood( "Azetoy", 1999,8),
                new CannedFood( "ColaToka", 2002,5),
                new CannedFood( "TamTam", 1989,2),
                new CannedFood( "ZetZam", 1975,1),
            };
        }

        public void CortOverdueCannedFood()
        {
            var filterOverdueCanned = _cannedFoodList.Where(cannedfood => (cannedfood.ProductionDate + cannedfood.ShelfLife) < _date.Year);
            ShowInfo(filterOverdueCanned);
        }

        private void ShowInfo(IEnumerable<CannedFood> cortCannedFoods)
        {
            Console.WriteLine("Просроченные банки тушенки :");

            foreach (var cannedFood in cortCannedFoods)
            {
                Console.WriteLine($"Название тушенки - {cannedFood.Name}");
            }
        }
    }

    class CannedFood
    {
        public CannedFood(string name, int productionDate, int shelfLife)
        {
            Name = name;
            ProductionDate = productionDate;
            ShelfLife = shelfLife;
        }

        public string Name { get; private set; }
        public int ProductionDate { get; private set; }
        public int ShelfLife { get; private set; }
    }
}