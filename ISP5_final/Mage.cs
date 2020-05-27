using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP5_final
{
    class Mage : Personazh
    {
        private int movespeed = 270;
        private int str = 20;
        private int damage = 75;
        private int armour = 15;
        private int agi = 25;
        private int intel = 50;
        public string Run()//скорость передвижения
        {
            return Type + " имеет скорость передвижения: " + movespeed;
        }

        public string TypeOfAttack()
        {
            return "Умеет пользоваться тяжелым и одноручным оружием";
        }
        public string Stats()//статы
        {
            return "Имеет характеристики:\n\t\t" + damage + " единиц атаки \n\t\t" + armour + " единиц защиты \n\t\t" + str + " силы \n\t\t" + agi + " ловкости \n\t\t" + intel + " интеллекта";
        }
        public string Specs()//Спеки
        {
            return Type + " выполняет роль танка и поддержки";
        }
        public string Perspectives()//Спеки
        {
            return Type + "в будущем может эволюционировать в Драконорожденного паладина, Астрального война или Ходячую крепость";
        }
    }
}
