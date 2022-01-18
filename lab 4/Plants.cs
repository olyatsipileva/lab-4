using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public enum Color
    {   
        Красный,
        Зеленый,
        Желтый,
        Белый,
        Жёлтый,
        Розовый,
        Фиолетовый,
        Бордовый,
        Оранжевый,
        Синий        
    }

    public enum Type
    {
        Роза,
        Хризантема,
        Пион,
        Лилия,
        Тюльпан,
        Гербера,
        Ландыш,
        Астра
    }

    public enum Kind
    {
        Хвойный,
        Лиственный
    }

    public abstract class Plants 
    {
        public float Hieght;

        public abstract string GetInfo();
    }

    public class Flower : Plants
    {
        public int CountPetals;
        public Color Color;
        public Type Type;

        public static Flower Generate(int randomSeed)
        {
            // рандом зависит от времени
            var rnd = new Random(randomSeed);

            return new Flower
            {
                Hieght = rnd.Next(1, 10) / 10.0f,
                CountPetals = rnd.Next(10, 150),
                Color = (Color)rnd.Next(0, 8),
                Type = (Type)rnd.Next(0, 7)
            };
        }

        public override string GetInfo()
        {
            var str = "Цветок";
            str += String.Format("\nВысота:{0} м.", this.Hieght);
            str += String.Format("\nКоличество лепестков:{0}", this.CountPetals);
            str += String.Format("\nЦвет:{0}", this.Color);
            str += String.Format("\nВид цветка:{0}", this.Type);


            return str;
        }
    }

    public class Bush : Plants
    {
        public bool HasFlowers;
        public int CountBranches;

        public override string GetInfo()
        {
            var str = "Куст";
            str += String.Format("\nВысота:{0} м.", this.Hieght);
            // ? : - сокращенная форма if else
            str += String.Format("\nНаличие цветков:{0}", this.HasFlowers == true ? "есть" : "нет");
            str += String.Format("\nКоличество веток:{0}", this.CountBranches);
            return str;
        }

        /// <summary>
        /// Метод генерации случайных чисел для класса кустарники
        /// </summary>
        /// <param name="randomSeed">параметр для случайной генерации</param>
        /// <returns></returns>
        public static Bush Generate(int randomSeed)
        {
            var rnd = new Random(randomSeed);
            return new Bush
            {
                Hieght = rnd.Next(3, 15) / 10.0f,
                HasFlowers = rnd.Next(0, 1) == 0,
                CountBranches = rnd.Next(10, 4000)
            };
        }
    }

    public class Tree : Plants
    {
        public float Radius;
        public Kind Kind;

        public override string GetInfo()
        {
            var str = "Дерево";
            str += String.Format("\nВысота:{0} м.", this.Hieght);
            str += String.Format("\nТип:{0}", this.Kind);
            str += String.Format("\nРадиус:{0} м.", this.Radius);
            return str;
        }

        public static Tree Generate(int randomSeed)
        {
            var rnd = new Random(randomSeed);
            return new Tree
            {
                Hieght =  rnd.Next(10, 200) / 10.0f,
                Kind = (Kind)rnd.Next(0, 1),
                Radius= rnd.Next(1, 30) / 10.0f
            };
        }

    }
}
