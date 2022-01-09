using System;

namespace DEMO_ASM2
{
    public class WinterShoe: IShoe
    {
       public WinterShoe()
        {

        }

        public WinterShoe(int size, string name) : base(size, name)
        {
        }

        public override string GetName()
        {
            return "Winter Shoe: " + Name;
        }

        public override string GetSize()
        {
            return "This is Winter Shoe: " + Size;
        }
    }
}