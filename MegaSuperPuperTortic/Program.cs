using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSuperPuperTortic
{
    internal class Program
    {
        static void Main()
        {
            CakeCreate CakeCreate = new CakeCreate();
            int position = 3;

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                CakeCreate.Menu();

                position = CakeCreate.Arrow(position, key);


                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    if (position == 3)
                    {
                        Console.WriteLine("Выберите форму тортика");
                        CakeCreate.OutputMenu1(CakeCreate.Forma());

                    }
                    else if (position == 4)
                    {
                        Console.WriteLine("Выберите размер тортика");
                        CakeCreate.OutputMenu1(CakeCreate.Size());

                    }
                    else if (position == 5)
                    {

                        Console.WriteLine("Выберите вкус тортика");
                        CakeCreate.OutputMenu1(CakeCreate.Vkus());
                    }
                    else if (position == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите количество коржей в тортике");
                        CakeCreate.OutputMenu1(CakeCreate.Korge());
                    }
                    else if (position == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите вкус глазури");
                        CakeCreate.OutputMenu1(CakeCreate.Glasure());
                    }
                    else if (position == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите декор тортика");
                        CakeCreate.OutputMenu1(CakeCreate.Dekor());
                    }
                    else if (position == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("Нажмите Esc, что-бы заказать торт");
                        CakeCreate.Save();

                        if (key == ConsoleKey.Escape)
                        {
                            CakeCreate.Menu();
                            CakeCreate.ClearOrder();
                        }

                    }
                }
            }
        }
    }
}
