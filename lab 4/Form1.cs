using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        List<Plants> plantsList = new List<Plants>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.plantsList.Clear();
            for (int i = 0; i < 10; i++)
            {
                this.plantsList.Add(new Flower());
            }
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
    }
}
