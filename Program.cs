using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace jey_sun
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers1 = new Person() { Name = "Tom", Age = 20, Hobby = new string[1] { "Футбол" } };
            Person pers2 = new Person() { Name = "Mike", Age = 21, Hobby = new string[2] { "Математика", "Программирование" } };

            Console.WriteLine("Исходный объект");
            Console.WriteLine(pers1);
            Console.WriteLine();

            Console.WriteLine("Исходный объект в Json");
            string json = JsonSerializer.Serialize<Person>(pers1);
            Console.WriteLine(json);

            Console.WriteLine("Исходный объект из Json");
            Person pers1DS = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(pers1DS);

            Console.WriteLine();

            Console.WriteLine("Исходный объект2");
            Console.WriteLine(pers2);
            Console.WriteLine();

            Console.WriteLine("Исходный объект в Json");
            json = JsonSerializer.Serialize<Person>(pers2);
            Console.WriteLine(json);

            Console.WriteLine("Исходный объект из Json");
            Person pers2DS = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(pers2DS);





            Console.ReadKey();
        }
    }
}
