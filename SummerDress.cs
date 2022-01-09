using System;

namespace DEMO_ASM2
{
    public class SummerDress: Dress
    {
        public SummerDress()
        {

        }

        public SummerDress(string color, string name) : base(color, name)
        {
        }
        public override string GetName()
        {
            return "Summer Dress: " + Name;
        }

        public override string GetColor()
        {
            return "This is Summer Dress: " + Color;
        }
    }
}