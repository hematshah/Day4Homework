using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.PrintingTheValuesOfChef();
            chef.ActiveChefs();

            Console.WriteLine("................................");

            Meat meat = new Meat();
            meat.PrintMeatText();
            meat.MeatRatio();
            Console.WriteLine("................................");

            MeatType meatType = new MeatType();
            meatType.PrintMeatText();
            meatType.ChooseMeatType();
            meatType.DifferentMeatTypes();



            Console.WriteLine("................................");

            Meat[] printingMeatMessages = { new Meat(), new MeatDish(), new MeatType() };
            printingMeatMessages[0].PrintMeatText();
            printingMeatMessages[1].PrintMeatText();
            printingMeatMessages[2].PrintMeatText();

            Console.WriteLine("................................");

            MeatVariations printingMeatText = new MeatVariations();
            printingMeatText.PrintMeatText();

            Console.WriteLine("................................");

            Meat printingMeatText1 = new MeatDish();
            printingMeatText1.PrintMeatText();


            Console.WriteLine("................................");




            // Console.ReadLine();

        }
    }
}
