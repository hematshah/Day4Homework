using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Homework
{
    class Chef : Cooking
    {
        private int numberOfChefs;
        private int howManyAvailableChefs;
        private string whatTypeOfChefs;

        // default constuctor for chef class 
        public Chef()
        {
            numberOfChefs = 0;


        }

        public Chef(int numberValue)
        {
            this.numberOfChefs = numberValue;
        }

        public Chef(int numberValue, int numberOfChefs)
        {
            this.numberOfChefs = numberValue;
            this.howManyAvailableChefs = numberOfChefs;

        }

        public void PrintingTheValuesOfChef()
        {
            Chef chef = new Chef();
            Chef chef1 = new Chef(2);
            Chef chef2 = new Chef(4, 1);
            Console.WriteLine(chef);
            Console.WriteLine(chef1);
            Console.WriteLine(chef2);
        }

        public int NumberOfChefs { get => numberOfChefs; set => numberOfChefs = value; }
        public string WhatTypesOfChefs { get => whatTypeOfChefs; set => whatTypeOfChefs = value; }

        public void ActiveChefs()
        {

            Console.WriteLine("how many Chefs have you hired ?");
            string numberOfChefsInString = Console.ReadLine();
            numberOfChefs = Int32.Parse(numberOfChefsInString);
            // Console.WriteLine(numberOfChefs);

            Console.WriteLine("What kind of Chefs have you hired");
            for (int i = 0; i < numberOfChefs; i++)
            {
                whatTypeOfChefs = Console.ReadLine();
            }

        }


    }
    class Cooking : Cookware
    {
        private string Dishes;
        private string CookingUtensils;
        private string InductionHob;

        public string Dishes1 { get => Dishes; set => Dishes = value; }
        public string CookingUtensils1 { get => CookingUtensils; set => CookingUtensils = value; }
        public string InductionHob1 { get => InductionHob; set => InductionHob = value; }



    }
    class Cookware
    {
        private int NumberOfCookwareTypes;
        private string CastIron;
        private string FryingPan;
        private string Wok;
    }



    class Meat
    {

        private double fat;
        private double leanMeat;

        public double Fats { get => fat; set => fat = value; }
        public double LeanMeats { get => leanMeat; set => leanMeat = value; }

        public Meat()
        {

        }

        public Meat(double x, double y)
        {
            fat = x;
            leanMeat = y;
        }

        public virtual void PrintMeatText()
        {

            Console.WriteLine("This is you butcher speaking --> we have different meat to fat ratios. ");

        }


        public void MeatRatio()
        {

            Console.WriteLine("please select the fat to lean meat ratio of your preferred choice from the range 1 to 10");
            Console.WriteLine(" How much fat do you wish for your meat to have on the scale of 1 to 10? ");
            string fatRatio = Console.ReadLine();
            fat = Int32.Parse(fatRatio);
            Console.WriteLine("How much of lean meat do you wish for your meat to have on a scale of 1 to 10");
            string leanMeatRatio = Console.ReadLine();
            leanMeat = Int32.Parse(leanMeatRatio);


            double meatRatio = (fat / leanMeat) * 100;
            Console.WriteLine("the lean meat percentage of your choosing is " + meatRatio + " %");


        }



    }
    class MeatType : Meat
    {
        private string redMeat;
        private string poultry;
        private string pork;

        public string Redmeat1 { get => redMeat; set => redMeat = value; }
        public string Poultry1 { get => poultry; set => poultry = value; }
        public string Pork1 { get => pork; set => pork = value; }

        public override void PrintMeatText()
        {
            Console.WriteLine("We have diffrent types of meat available for veriety of meat dishes. ");
        }

        Dictionary<int, String> selection = new Dictionary<int, string>();
        public Dictionary<int, string> ChooseMeatType()
        {

            selection.Add(1, "redmeat");
            selection.Add(2, "poultry");
            selection.Add(3, "pork");

            return selection;
        }
        public void DifferentMeatTypes()
        {
            Console.WriteLine("These are our selected type of meats available");
            MeatType meatType = new MeatType();
            Dictionary<int, string> typeOfmeats = meatType.ChooseMeatType();

            Console.WriteLine("We have the following meat types: " + typeOfmeats[1] + " " + typeOfmeats[2] + " " + typeOfmeats[3]);
            Console.WriteLine(" Write which type of meat you are eager to try");
            String chosenTypeOfmeat = Console.ReadLine();


            // issues with the if statement
            if (typeOfmeats[1] == chosenTypeOfmeat)
            {
                redMeat = chosenTypeOfmeat;
                Console.WriteLine("Your preferred meat type is? " + redMeat);
            }
            else if (chosenTypeOfmeat == typeOfmeats[2])
            {
                poultry = chosenTypeOfmeat;
                Console.WriteLine("Your preferred meat type is? " + poultry);
            }
            else if (chosenTypeOfmeat == typeOfmeats[3])
            {
                pork = chosenTypeOfmeat;
                Console.WriteLine("Your preferred meat type is? " + pork);
            }




        }
    }
    class MeatVariations : MeatType
    {
        private string chicken;
        private string cow;
        private string scheep;
        private string goat;
        private string fish;

        public string Chicken { get => chicken; set => chicken = value; }
        public string Cow { get => cow; set => cow = value; }
        public string Scheep { get => scheep; set => scheep = value; }
        public string Goat { get => goat; set => goat = value; }
        public string Fish { get => fish; set => fish = value; }



    }
    class MeatDish : MeatVariations
    {
        private string Curry;
        private bool eaten;

        public override void PrintMeatText()
        {
            Console.WriteLine(" Our signature dish is curry !");
        }
    }


    class Vegetables
    {
        private string Brocoli;
        public string SunFlowerSeed;
        private string Lettuce;
        private string Tomatoes;
        public string olives;
        public string potatoes;

    }
    class FryingVegDish : Oil
    {
        private string chips;

        public bool eaten;
    }
    class Oil : Vegetables
    {
        private string Vegetable;
        private string SunFlower;
        private string Olive;
        public int TypeOfoils;
    }

}
