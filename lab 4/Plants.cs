using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public enum Color
    {   
        Red,
        Green,
        Blue,
        White,
        Yellow,
        Pink,
        Purple,
        Orange,
        Burgundy
    }
    public enum Type
    {
        Rose,
        GoldenDaisy,
        Chamomile,
        Peonies,
        Lilies,
        Tulips,
        Gerbera,
        Asters
    }
    public enum Kind
    {
        Coniferous,
        Leafy
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

        public override string GetInfo()
        {
            var str = "Цветок";
            str += String.Format("\nВысота:{0}", this.Hieght);
            return str;
        }

        public static Flower Generate()
        {
            var rnd = new Random();
            return new Flower
            {
                Hieght = rnd.Next(1, 10) / 10.0f,
                CountPetals = rnd.Next(10, 150),
                Color = (Color)rnd.Next(0, 8),
                Type = (Type)rnd.Next(0, 7)
            };
        }
    }

    public class Bush : Plants
    {
        public bool HasFlowers;
        public int CountBranches;

        public override string GetInfo()
        {
            var str = "Куст";
            str += String.Format("\nВысота:{0}", this.Hieght);
            return str;
        }

        public static Bush Generate()
        {
            var rnd = new Random();
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
            str += String.Format("\nВысота:{0}", this.Hieght);
            return str;
        }

        public static Tree Generate()
        {
            var rnd = new Random();
            return new Tree
            {
                Hieght =  rnd.Next(10, 200) / 10.0f,
                Kind = (Kind)rnd.Next(0, 1),
                Radius= rnd.Next(1, 30) / 10.0f
            };
        }

    }
}
