using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP5_final
{
    class Personazh
    {
        private string name;
        public string Name//имя персонажа
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age//возраст
        {
            get { return age; }
            set
            {
                if ((value >= 0) && (value <= 100))
                    age = value;
                else Console.WriteLine("err");
            }
        }

        private int job;
        public int Job//номер специализации
        {
            get { return job; }
            set { job = value; }
        }

        private string type;
        public string Type//специализация
        {
            get { return type; }
            set { type = value; }
        }

        public string ShowPers() //показать персонажа
        {
            return "Персонажа зовут " + name + ", его возраст " + age;
        }

        
        ~Personazh()
        {
            Console.WriteLine("Del Pers");
        }
    }  
}
