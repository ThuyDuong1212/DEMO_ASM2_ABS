using System;

namespace DEMO_ASM2
{
    public abstract Fashion
    {

        public abstract Shoe CreateShoe(int size ,string name);

        public abstract Dress CreateDress(string color, string name);
    }
}