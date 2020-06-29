using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jey_sun
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Hobby { get; set;}

        public override string ToString() //вывести карточку на экран
        {
            string hoby = ""; //перебрать все хобби

            for(int i = 0; i < Hobby.Length; i++)
            {
                if (i < Hobby.Length - 1) { hoby += Hobby[i] + ", "; } //если не последний
                else { hoby += Hobby[i] + "."; }
            }

            return "\nИмя: " + Name + ", \nВозраст: " + Age + " лет, " + "\nХобби: " + hoby;
        }
    }
}
