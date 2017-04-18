namespace _06.FoodShortage
{
    class Citizen : IBuyer
    {

        public Citizen(string name)
        {
            this.Name = name;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }

        public int Food { get; set; }
        public string Name { get; set; }
    }
}
