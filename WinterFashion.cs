using System;

namespace DEMO_ASM2
{
    public class WinterFashion: Fashion
    {
        public override Shoe CreateShoe(int size, string name)
        {
            return new WinterShoe(size, name);
        }

        public override Dress CreateDress(string color, string name)
        {
            return new WinterDress(color, name);
        }
    }
}