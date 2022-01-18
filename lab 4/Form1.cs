using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        List<Plants> plantsList = new List<Plants>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // СЮДА, чтобы при запуске приложения что-то показывалось на форме
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.plantsList.Clear();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то мандарин
                        this.plantsList.Add(Flower.Generate());
                        break;
                    case 1: // если 1 то виноград
                        this.plantsList.Add(Bush.Generate());
                        break;
                    case 2: // если 2 то арбуз
                        this.plantsList.Add(Tree.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }

        // функция выводит информацию о количестве фруктов на форму
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int flowersCount = 0;
            int bushesCount = 0;
            int treesCount = 0;

            // пройдемся по всему списку
            foreach (var plant in this.plantsList)
            {
                // помните, что в списки у нас лежат фрукты,
                // то есть объекты типа Fruit
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (plant is Flower) // читается почти как чистый инглиш, "если fruit есть Мандарин"
                {
                    flowersCount += 1;
                }
                else if (plant is Bush)
                {
                    bushesCount += 1;
                }
                else if (plant is Tree)
                {
                    treesCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Цветы\tКусты\tДеревья"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", flowersCount, bushesCount, treesCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.plantsList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            // взяли первый фрукт
            var plant = this.plantsList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
            this.plantsList.RemoveAt(0);

            // ну а теперь предложим покупателю его фрукт
            txtOut.Text = plant.GetInfo();

            // обновим информацию о количестве товара на форме
            ShowInfo();
        }
    }
}
