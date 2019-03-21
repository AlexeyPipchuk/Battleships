using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmagorov
{
    abstract class Ship  
    {
        public bool death; 
        public static LinkedList<Ship> ships = new LinkedList<Ship>(); // список всех кораблей соперника
        public static LinkedList<Ship> Mships = new LinkedList<Ship>(); // список всез наших кораблей
        public static LinkedList<Ship> GetShips
        {
            get { return ships; }
        }
        public static LinkedList<Ship> GetMShips
        {
            get { return Mships; }
        }

        public LinkedList<MyButton> arroundPoints; // список полей вокруг подбитого корабля, которые надо пометить точкой
        public abstract bool haveItPoint(MyButton btn); // проверка, что поле принадлежит тому или иному кораблю
        public abstract void damage(MyButton btn); // нанести урон
    };

    class OnePointShip : Ship // реализация однопалубника
    {
        public MyButton first; // только одна клетка
        public OnePointShip(MyButton btn, LinkedList<MyButton> list)
        {
            first = btn;
            death = false;
            arroundPoints = list;
        }
        public override bool haveItPoint(MyButton btn)
        {
            if (first.Equals(btn) == true) return true;
            return false;
        }
        public override void damage(MyButton btn) // убивается одним выстрелом
        {
            death = true;
            foreach (MyButton i in arroundPoints)  // ставим точки вокруг подбитого корабля
            {
                i.Text = "•";
                i.Enabled = false;
                i.Enabled = false;
            }
        }
    };

    class TwoPointShip : Ship // реализация двупалубника
    {
        MyButton first;
        MyButton second; // есть еще и вторая клетка
        public TwoPointShip(MyButton btn1, MyButton btn2, LinkedList<MyButton> list)
        {
            first = btn1;
            second = btn2;
            death = false;
            arroundPoints = list;
        }
        public override bool haveItPoint(MyButton btn)
        {
            if (first.Equals(btn) == true || second.Equals(btn) == true) return true;
            return false;
        }

        public override void damage(MyButton btn)
        {
            if (first.Equals(btn) == true) first.Enabled = false;
            if (second.Equals(btn) == true) second.Enabled = false;
            if (first.Enabled != false || second.Enabled != false) return; // если только одна клетка подбита, выходим
            death = true;
            foreach (MyButton i in arroundPoints) // ставим точки вокруг подбитого корабля
            {
                i.Text = "•";
                i.Enabled = false;
                i.Enabled = false;
            }
            first.Text = "X";
            second.Text = "X";
        }
    };
}
