using System;

namespace DEMO_ASM2
{
    public class Store
    {
        private Dress dress;
        private Shoe Shoe;

        private Fashion fashion;

        public Store()
        {
            fashion = new Summer();
            dress = fashion.CreateDress("red", "vay dai");
            shoe = fashion.CreateShoe(24, "giay");
        }

        public void GetName() 
        {
            shoe.GetName();
            dress.GetName();
        }

        public void GetSize() 
        {
            shoe.GetSize();
        }

        public void GetColor()
        {
            dress.GetColor();
        }

        public void ChangeTheme(string theme)
        {
            if (theme == "Winter") fashion = new WinterFashion();
            else fashion = new SummerFashion();
            
            UpdateInteface();

        }

        private void UpdateInteface() {
            string nameD = dress.Name;
            string nameS = shoe.Name;
            string color = dress.Color;
            int size = shoe.Size;

            dress = fashion.CreateDress(color, nameD);
            shoe = fashion.CreateShoe(size, nameS);
            
            GetName();
            GetSize();

            GetColor();
        }

    }
}