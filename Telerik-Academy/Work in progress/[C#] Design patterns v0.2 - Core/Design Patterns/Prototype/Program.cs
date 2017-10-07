using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorManager = new ColorManager();

            //init standart colors
            colorManager["red"] = new Color(255,0,0);
            colorManager["green"] = new Color(0,255,0);
            colorManager["blue"] = new Color(0,0,255);

            //init personalized colors
            colorManager["flame"] = new Color(255, 54, 0);
            colorManager["peace"] = new Color(128, 211, 128);
            colorManager["war"] = new Color(211, 34, 20);

            var color1 = colorManager["red"].Clone() as Color;
            var color2 = colorManager["flame"].Clone() as Color;
            var color3 = colorManager["war"].Clone() as Color;

            Console.WriteLine(color3);
        }
    }

    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    public class Color:ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;
        public Color(int red,int green,int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }
        public override ColorPrototype Clone()
        {
            return MemberwiseClone() as ColorPrototype;
        }

        public override string ToString()
        {
            return $"Cloned color RGB: {_red},{_green},{_blue}";
        }
    }

    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key,value); }
        }
    }
}
