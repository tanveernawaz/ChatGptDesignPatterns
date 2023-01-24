using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    class Sandwich
    {
        public string BreadType { get; set; }
        public string MeatType { get; set; }
        public string CheeseType { get; set; }
        public bool IsToasted { get; set; }
        public List<string> Vegetables { get; set; }
    }

    abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void AddBread();
        public abstract void AddMeat();
        public abstract void AddCheese();
        public abstract void AddVegetables();
        public abstract void SetToasted();
    }

    class BLTSandwichBuilder : SandwichBuilder
    {
        public override void AddBread()
        {
            sandwich.BreadType = "White";
        }

        public override void AddMeat()
        {
            sandwich.MeatType = "Bacon";
        }

        public override void AddCheese()
        {
            sandwich.CheeseType = "None";
        }

        public override void AddVegetables()
        {
            sandwich.Vegetables = new List<string> { "Lettuce", "Tomato" };
        }

        public override void SetToasted()
        {
            sandwich.IsToasted = true;
        }
    }

    class SandwichMaker
    {
        private readonly SandwichBuilder sandwichBuilder;

        public SandwichMaker(SandwichBuilder builder)
        {
            sandwichBuilder = builder;
        }

        public void BuildSandwich()
        {
            sandwichBuilder.CreateNewSandwich();
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeat();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVegetables();
            sandwichBuilder.SetToasted();
        }

        public Sandwich GetSandwich()
        {
            return sandwichBuilder.GetSandwich();
        }
    }
}
