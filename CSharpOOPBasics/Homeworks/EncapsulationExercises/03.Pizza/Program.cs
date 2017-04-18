using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<Item> itemCollection = new List<Item>();

            List<Pizza> pizzaCollection = new List<Pizza>();

            string previousItem = null;

            int pizzaIndex = 0;

            try
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    List<string> inputParameters = input.Split(' ').ToList();

                    
                    if (inputParameters[0] == "Pizza")
                    {
                        string name = inputParameters[1];
                        int numberOfToppings = int.Parse(inputParameters[2]);

                        Pizza pizza = new Pizza(name, numberOfToppings);

                        pizzaCollection.Add(pizza);
                        itemCollection.Add(pizza);

                    }

                    if (inputParameters[0] == "Dough")
                    {
                        string flourType = inputParameters[1];
                        string bakingTechnique = inputParameters[2];
                        int weight = int.Parse(inputParameters[3]);

                        Dough dough = new Dough(flourType, bakingTechnique, weight);

                        
                        if (pizzaCollection.Count!=0 && pizzaCollection[pizzaCollection.Count - 1].Dough == null)
                        {
                            pizzaCollection[pizzaCollection.Count - 1].Dough = dough;
                        }
                        else
                        {
                            itemCollection.Add(dough);
                        }
                    }

                    if (inputParameters[0] == "Topping")
                    {
                        string type = inputParameters[1];
                        int weight = int.Parse(inputParameters[2]);

                        Topping topping = new Topping(type, weight);

                        if (pizzaCollection.Count != 0 && pizzaCollection[pizzaCollection.Count - 1].ToppingsCollection.Count !=
                            pizzaCollection[pizzaCollection.Count - 1].NumberOfTopings)
                        {
                            pizzaCollection[pizzaCollection.Count - 1].ToppingsCollection.Add(topping);
                        }
                        else
                        {
                            itemCollection.Add(topping);
                        }
                    }
                }

                foreach (var element in itemCollection)
                {
                    Console.WriteLine(element);
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

    class Dough : Item
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private List<string> allowedDoughTypes = new List<string>();

        public const int BaseCaloriesPerGram = 2;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            InitializeDoughType();
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.Modifier = GetModifier();
        }

        private void InitializeDoughType()
        {
            this.allowedDoughTypes.Add("white");
            this.allowedDoughTypes.Add("wholegrain");
            this.allowedDoughTypes.Add("crispy");
            this.allowedDoughTypes.Add("chewy");
            this.allowedDoughTypes.Add("homemade");
        }

        private double GetModifier()
        {
            double aggregatedModifier = BaseCaloriesPerGram;

            switch (this.FlourType.ToLower())
            {
                case "white":
                    aggregatedModifier *= 1.5d;
                    break;
                case "wholegrain":
                    aggregatedModifier *= 1d;
                    break;
            }

            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    aggregatedModifier *= 0.9d;
                    break;
                case "chewy":
                    aggregatedModifier *= 1.1d;
                    break;
                case "homemade":
                    aggregatedModifier *= 1d;
                    break;
            }

            return aggregatedModifier;
        }

        public string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (!allowedDoughTypes.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (!allowedDoughTypes.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public int Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double Modifier { get; set; }

        public override double GetCalories()
        {
            double totalCalories = this.Weight * this.Modifier;

            return totalCalories;
        }

        public override string ToString()
        {
            return this.GetCalories().ToString("F2");
        }
    }

    public class Item
    {
        public Item()
        {

        }

        public virtual double GetCalories()
        {
            return 0;
        }
    }

    class Pizza : Item
    {
        private string name;
        private int numberOfToppings;


        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.NumberOfTopings = numberOfToppings;
            this.ToppingsCollection = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value == " " || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }
        public List<Topping> ToppingsCollection { get; set; }
        public Dough Dough { get; set; }

        public int NumberOfTopings
        {
            get { return this.numberOfToppings; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public override double GetCalories()
        {
            double totalCalories = this.Dough.GetCalories();

            var sum = ToppingsCollection.Sum(x => x.GetCalories());

            totalCalories += sum;

            return totalCalories;
        }

        public override string ToString()
        {
            string pizza = this.Name;
            pizza += " - ";
            pizza += String.Format("{0:F2} Calories.", this.GetCalories());

            return pizza;
        }


    }

    class Topping : Item
    {
        public const int BaseCaloriesPerGram = 2;
        private static List<string> allowedToppingTypes;
        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.Modifier = GetModifier();
        }

        static Topping()
        {
            Topping.allowedToppingTypes = new List<string>();
            allowedToppingTypes.Add("meat");
            allowedToppingTypes.Add("veggies");
            allowedToppingTypes.Add("cheese");
            allowedToppingTypes.Add("sauce");
        }

        private double GetModifier()
        {
            double aggregatedModifier = BaseCaloriesPerGram;

            switch (this.Type.ToLower())
            {
                case "meat":
                    aggregatedModifier *= 1.2d;
                    break;
                case "veggies":
                    aggregatedModifier *= 0.8d;
                    break;
                case "cheese":
                    aggregatedModifier *= 1.1d;
                    break;
                case "sauce":
                    aggregatedModifier *= 0.9d;
                    break;
            }

            return aggregatedModifier;
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (!allowedToppingTypes.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public int Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range[1..50].");
                }

                this.weight = value;
            }
        }

        public double Modifier { get; set; }

        public override double GetCalories()
        {
            double totalCalories = this.Weight * this.Modifier;

            return totalCalories;
        }

        public override string ToString()
        {
            return this.GetCalories().ToString("F2");
        }
    }
}
