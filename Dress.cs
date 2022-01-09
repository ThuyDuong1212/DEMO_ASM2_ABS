using System;

namespace DEMO_ASM2
{
    public abstract Dress
    {
        public string Name
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }

        public Dress()
        {
            Color = "Unknown color";
            Name = "Unknown name";
        }

        public  Dress(string color, string name)
        {
            Color = color;
            Name = name;
        }
        public abstract string GetName();

        public abstract string GetColor();
    }
}