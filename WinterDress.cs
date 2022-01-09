using System;

namespace DEMO_ASM2
{
    public class WinterDress: Dress
    {
        public WinterDress()
        {

        }

        public WinterDress(string color, string name) : base(color, name)
        {
        }

        public override string GetName()
        {
            return "Winter Dress: " + Name;
        }

        public string GetColor()
        {
            return "This is Winter Dress: " + Color;
        }
    }
}