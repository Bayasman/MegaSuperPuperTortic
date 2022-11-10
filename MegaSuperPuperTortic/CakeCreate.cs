using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSuperPuperTortic
{
    internal class CakeCreate
    {
        private int price;
        private string zakaz;        
        public void Menu()
        {
            Console.WriteLine("СОЧНЫЕ БУЛОЧКИ БАСИКА");
            Console.WriteLine("Выберете параметр торта");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Заказ завершен.");
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Ваш заказ: " + zakaz);
        }

        public List<Menu1> Forma()
        {
            Menu1 krug = new Menu1();
            krug.title = "Круг";
            krug.price = 100;

            Menu1 zvezda = new Menu1();
            zvezda.title = "Звезда";
            zvezda.price = 150;

            Menu1 kvadrat = new Menu1();
            kvadrat.title = "Квадрат";
            kvadrat.price = 200;

            List<Menu1> forma = new List<Menu1>();
            forma.Add(krug);
            forma.Add(zvezda);
            forma.Add(kvadrat);

            return forma;
        }
        public List<Menu1> Size()
        {
            Menu1 big = new Menu1();
            big.title = "Большой";
            big.price = 5000;

            Menu1 middle = new Menu1();
            middle.title = "Средний";
            middle.price = 3000;

            Menu1 small = new Menu1();
            small.title = "Маленький";
            small.price = 1000;

            List<Menu1> size = new List<Menu1>();
            size.Add(big);
            size.Add(middle);
            size.Add(small);

            return size;
        }
        public List<Menu1> Vkus()
        {
            Menu1 choco = new Menu1();
            choco.title = "Шоколадный";
            choco.price = 2500;

            Menu1 med = new Menu1();
            med.title = "Медовый";
            med.price = 1500;

            Menu1 coffee = new Menu1();
            coffee.title = "Кофейный";
            coffee.price = 1000;

            List<Menu1> Vkus = new List<Menu1>();
            Vkus.Add(choco);
            Vkus.Add(med);
            Vkus.Add(coffee);

            return Vkus;
        }
        public List<Menu1> Korge()
        {
            Menu1 one = new Menu1();
            one.title = "1 корж";
            one.price = 2000;
            Menu1 two = new Menu1();
            two.title = "2 коржа";
            two.price = 3000;
            Menu1 trek = new Menu1();
            trek.title = "3 коржа";
            trek.price = 5000;

            List<Menu1> korge = new List<Menu1>();
            korge.Add(one);
            korge.Add(two);
            korge.Add(trek);

            return korge;
        }
        public List<Menu1> Glasure()
        {
            Menu1 choco = new Menu1();
            choco.title = "Шоколадная";
            choco.price = 2500;

            Menu1 med = new Menu1();
            med.title = "Медовая";
            med.price = 1500;

            Menu1 coffee = new Menu1();
            coffee.title = "Кофейная";
            coffee.price = 1000;

            List<Menu1> glasure = new List<Menu1>();
            glasure.Add(choco);
            glasure.Add(med);
            glasure.Add(coffee);

            return glasure;
        }
        public List<Menu1> Dekor()
        {
            Menu1 berry = new Menu1();
            berry.title = "Ягоды";
            berry.price = 5000;
            Menu1 figure = new Menu1();
            figure.title = "Фигурки";
            figure.price = 2000;

            List<Menu1> glasure = new List<Menu1>();
            glasure.Add(berry);
            glasure.Add(figure);

            return glasure;
        }

        public void OutputMenu1(List<Menu1> box)
        {
            int position = 1;
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                foreach (Menu1 podmenu in box)
                {
                    Console.WriteLine("  " + podmenu.title + " - " + podmenu.price);
                }
                position = Arrow(position, key);
                if (key == ConsoleKey.Enter)
                {
                    price = price + box[position].price;
                    zakaz = zakaz + box[position].title;
                    break;
                }
                if (key == ConsoleKey.Escape)
                {
                    Menu();
                }
            }
        }
        public int Arrow(int position, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.DownArrow:
                    position++;

                    break;
                case ConsoleKey.UpArrow:
                    position--;
                    break;
            }


            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            return position;
        }

        public void ClearOrder()
        {
            zakaz = "";
            price = 0;
        }

        public void Save()
        {
            File.AppendAllText("cake_story.txt", price.ToString());
            File.AppendAllText("cake_story.txt", zakaz.ToString());
        }
    }
}
