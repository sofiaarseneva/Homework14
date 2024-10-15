using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моделируем животных!\n");

            try
            {
                Console.WriteLine("Введите кличку кота:");
                string name_cat = Console.ReadLine();

                Cat cat = new Cat(name_cat, "Мяу!Мяу!Мяу!");
                cat.ShowInfo();

                Console.WriteLine("\nВведите кличку собаки:");
                string name_dog = Console.ReadLine();

                Dog dog = new Dog(name_dog, "Гав!Гав!Гав!");
                dog.ShowInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
