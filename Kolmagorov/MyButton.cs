using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kolmagorov
{
    enum States { none, defnone, ship, defship, aroundship };
    // класс поля - наследован от библотечного класса кнопки 
    class MyButton : System.Windows.Forms.Button
    {
        public States state; // каждое поле находится в каком то состоянии(пусто, корабль, подбитый корабль ...)
        static public MyButton[] Btns = new MyButton[49]; // все поля соперника
        static public MyButton[] MBtns = new MyButton[49]; // все наши поля
        static public int count = 0; // количество полей соперника
        static public int countM = 0; // количество наших полей
        static public MyButton ranen;  // клетка, в которую пишется позиция при первом попадании в двупалубник
        static public Random gen = new Random(); // генератор расстановки

        //конструктор
        public MyButton()
        {
            Enabled = true;
            ranen = null;
            state = States.none;

            // размещение 
            Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
                     | AnchorStyles.Left)
                     | AnchorStyles.Right)));
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.Highlight;
            BackgroundImageLayout = ImageLayout.None;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Margin = new Padding(0);
            Size = new System.Drawing.Size(60, 60);
            UseVisualStyleBackColor = false;
            // первые 49 кнопок идут в наше поле, вторые 49 в поле соперника
            if (count >= 49)
            {
                MBtns[countM] = this;
                countM++;
            }
            else
            {
                Btns[count] = this;
                count++;
            }
        }

        public static void EnemyShot()
        {
            int cur = 0;
        l1:
            // если нет раненого корабля
            if (ranen == null) while (MBtns[cur].Enabled != true) cur = (int)((gen.Next(49) + gen.Next(49) + gen.Next(49)
  + gen.Next(49) + gen.Next(49) + gen.Next(49)) / 6.0f);
            else
            {
                int index = getIndexMybtn(ranen);
            l2:
                cur = (int)(gen.NextDouble() * 4); // рандомно выбираем куда добить раненый корабль(сверху выстрелить, слева ...)
                switch (cur)
                {
                    // везде идут проверки, не выйдем ли мы за поле, если выходим, рандомим заново
                    case 0:
                        if (Kolmagorov_Battleships.linkOnField.GetCellPosition(ranen).Column != 0) cur = index + 1;
                        else goto l2;
                        break;
                    case 1:
                        if (Kolmagorov_Battleships.linkOnField.GetCellPosition(ranen).Column != 6) cur = index - 1; 
                        else goto l2;
                        break;
                    case 2:
                        if (Kolmagorov_Battleships.linkOnField.GetCellPosition(ranen).Row != 0) cur = index + 7; 
                        else goto l2;
                        break;
                    case 3:
                        if (Kolmagorov_Battleships.linkOnField.GetCellPosition(ranen).Row != 6) cur = index - 7; 
                        else goto l2;
                        break;
                }
                if (MBtns[cur].Enabled != true) goto l2; // если позиция уже простреляна, еще раз ищем 
            }
          
            MBtns[cur].Enabled = false; // по полю нельзя больше стрелять
            if (MBtns[cur].state == States.ship)
            { // если попал, ударяем корабль
              
                GetShip(MBtns[cur]).damage(MBtns[cur]);
                MBtns[cur].BackColor = System.Drawing.Color.Red;
                MBtns[cur].state = States.defship;
                MBtns[cur].Text = "X";

                if (GetShip(MBtns[cur]) is TwoPointShip) // если корабль двухпалубник
                {
                    if (ranen == null) ranen = MBtns[cur]; // пытаемся добить двухпалубни
                    else {
                        GetShip(MBtns[cur]).death = true;
                        ranen = null;
                    } 
                }
                goto l1;
            }
            else // если не попали
            {
                MBtns[cur].state = States.defnone;
                MBtns[cur].Text = "•";
            }
        }

        public static void Win()
        {
            foreach (Ship i in Ship.ships)
            {
                if (i.death != true) return;
            }
            // если все корабли подбиты
            for (int i = 0; i < 49; i++)
            {
                Btns[i].Enabled = false;
                if (Btns[i].Enabled == true)
                {
                    Btns[i].Enabled = false;
                    Btns[i].Text = "•";
                }
            }
            System.Windows.Forms.Label label = Kolmagorov_Battleships.LabelWin;
            label.Size = new System.Drawing.Size(100, 56);
            label.Text = "YOU WIN!!!!";
            for (int i = 0; i < 49; i++)
            {
                MBtns[i].Enabled = false;
                Btns[i].Enabled = false;
            }
        }

        public static void Lose()
        {
            foreach (Ship i in Ship.Mships)
            {
                if (i.death != true) return;
            }
            // если все корабли подбиты
            for (int i = 0; i < 49; i++)
            {
                MBtns[i].Enabled = false;
                if (MBtns[i].Enabled == true)
                {
                    MBtns[i].Enabled = false;
                    MBtns[i].Text = "•";
                }
            }
            System.Windows.Forms.Label label = Kolmagorov_Battleships.LabelWin;
            label.Size = new System.Drawing.Size(100, 56);
            label.Text = "YOU LOSE!!!!";
            for (int i = 0; i < 49; i++)
            {
                if (Btns[i].state == States.ship && Btns[i].Enabled == true) Btns[i].BackColor = System.Drawing.Color.Yellow;
                MBtns[i].Enabled = false;
                Btns[i].Enabled = false;
            }
        }

        // переопределяем метод класса Button 
        protected override void OnClick(EventArgs e) // по выстрелу
        {
            if (Enabled) // если не тронута
            {
                Enabled = false;
                if (state == States.ship)
                {
                    GetShip(this).damage(this);  // находим корабль по этой ячейке и наносим урон
                    BackColor = System.Drawing.Color.Red;
                    state = States.defship;
                    Text = "X";
                    Win();  // проверка на выигрыш
                }
                else
                {
                    state = States.defnone;
                    Text = "•";
                    EnemyShot(); // если мы не попали, стреляет соперник
                    Lose();  // проверка на проигрыш
                }
            }
        }

        public static LinkedList<MyButton> NoteArroundOne(TableLayoutPanelCellPosition pos, int index) // определение границ для вражеского однопалубника
        {
            LinkedList<MyButton> arrounds = new LinkedList<MyButton>();
            if (pos.Row != 0) {
                arrounds.AddLast(Btns[index + 7]);
                Btns[index + 7].state = States.aroundship;
            }
            if (pos.Row != 6) {
                arrounds.AddLast(Btns[index - 7]);
                Btns[index - 7].state = States.aroundship;
            }
            if (pos.Column != 0)
            {
                Btns[index + 1].state = States.aroundship;
                arrounds.AddLast(Btns[index + 1]);
                if (pos.Row != 0) {
                    arrounds.AddLast(Btns[index + 8]);
                    Btns[index + 8].state = States.aroundship;
                }
                if (pos.Row != 6) {
                    arrounds.AddLast(Btns[index - 6]);
                    Btns[index - 6].state = States.aroundship;
                }
            }
            if (pos.Column != 6)
            {
                Btns[index - 1].state = States.aroundship;
                arrounds.AddLast(Btns[index - 1]);
                if (pos.Row != 0) {
                    arrounds.AddLast(Btns[index + 6]);
                    Btns[index + 6].state = States.aroundship;
                }
                if (pos.Row != 6) {
                    arrounds.AddLast(Btns[index - 8]);
                    Btns[index - 8].state = States.aroundship;
                }
            }
            return arrounds;
        }

        public static LinkedList<MyButton> MNoteArroundOne(TableLayoutPanelCellPosition pos, int index) // определение границ для нашего однопалубника
        {
            LinkedList<MyButton> arrounds = new LinkedList<MyButton>();
            if (pos.Row != 0)
            {
                arrounds.AddLast(MBtns[index + 7]);
                MBtns[index + 7].state = States.aroundship;
            }
            if (pos.Row != 6)
            {
                arrounds.AddLast(MBtns[index - 7]);
                MBtns[index - 7].state = States.aroundship;
            }
            if (pos.Column != 0)
            {
                MBtns[index + 1].state = States.aroundship;
                arrounds.AddLast(MBtns[index + 1]);
                if (pos.Row != 0)
                {
                    arrounds.AddLast(MBtns[index + 8]);
                    MBtns[index + 8].state = States.aroundship;
                }
                if (pos.Row != 6)
                {
                    arrounds.AddLast(MBtns[index - 6]);
                    MBtns[index - 6].state = States.aroundship;
                }
            }
            if (pos.Column != 6)
            {
                MBtns[index - 1].state = States.aroundship;
                arrounds.AddLast(MBtns[index - 1]);
                if (pos.Row != 0)
                {
                    arrounds.AddLast(MBtns[index + 6]);
                    MBtns[index + 6].state = States.aroundship;
                }
                if (pos.Row != 6)
                {
                    arrounds.AddLast(MBtns[index - 8]);
                    MBtns[index - 8].state = States.aroundship;
                }
            }
            return arrounds;
        }

        public static LinkedList<MyButton> NoteArroundTwo(TableLayoutPanelCellPosition pos,
            TableLayoutPanelCellPosition pos2, int index, int index2) // определение границ для вражеского двупалубника
        {
            LinkedList<MyButton> arrounds;
            LinkedList<MyButton> arrounds2;
            arrounds = NoteArroundOne(pos, index);
            Btns[index2].state = States.ship; // первая клетка замазала вторую, но мы ее возвращаем
            arrounds2 = NoteArroundOne(pos2, index2);
            Btns[index].state = States.ship; // со второй та же история
            foreach (MyButton i in arrounds2)
            {
                arrounds.AddLast(i);
            }
            return arrounds;
        }

        public static LinkedList<MyButton> MNoteArroundTwo(TableLayoutPanelCellPosition pos,
           TableLayoutPanelCellPosition pos2, int index, int index2) // определение границ для нашего двупалубника
        {
            LinkedList<MyButton> arrounds;
            LinkedList<MyButton> arrounds2;
            arrounds = MNoteArroundOne(pos, index);
            MBtns[index2].state = States.ship; // первая клетка замазала вторую, но мы ее возвращаем
            arrounds2 = MNoteArroundOne(pos2, index2);
            MBtns[index].state = States.ship; // со второй та же история
            foreach (MyButton i in arrounds2)
            {
                arrounds.AddLast(i);
            }
            return arrounds;
        }

        public static int getIndexMybtn(MyButton btn)
        {
            for (int i = 0; i < 49; i++)
            {
                if (MBtns[i].Equals(btn)) return i;
            }
            return 0;
        }  // найти клетку в массиве

        public static Ship GetShip(MyButton btn)
        {
            foreach (Ship i in Ship.ships)
            {
                if (i.haveItPoint(btn)) return i;
            }
            foreach (Ship i in Ship.Mships)
            {
                if (i.haveItPoint(btn)) return i;
            }
            return null;
        }  // найти корабль по клетке 
    }
}
