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
    public class Plants 
    {
        public float Hieght;
    }

    public class Flower : Plants
    {
        public int CountPetals;
        public Color Color;
        public Type Type;
    }

    public class Bush : Plants
    {
        public bool HasFlowers;
        public int CountBranches;
    }

    public class Tree : Plants
    {
        public float Radius;
        public Kind Kind;
    }
}
