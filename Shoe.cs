using System;

namespace DEMO_ASM2
{
    public abstract Shoe
    {
        public string Name
        {
            get;
            set;
        }
        public int Size
        {
            get;
            set;
        }

        public Shoe()
        {
            Size = 30;
            Name = "Unknown name";
        }

        public Shoe(int size, string name)
        {
            Size = size;
            Name = name;
        }
        public abstract string GetName();

        public abstract string GetModel();
    }
}