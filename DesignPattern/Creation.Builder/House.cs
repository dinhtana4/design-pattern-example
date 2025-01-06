namespace Creation.Builder
{
    public class House
    {
        public string Foundation { get; set; }
        public string Structure { get; set; }
        public string Roof { get; set; }
        public bool HasGarden { get; set; }
        public bool HasSwimmingPool { get; set; }

        public void Display()
        {
            Console.WriteLine("House Details:");
            Console.WriteLine($"Foundation: {Foundation}");
            Console.WriteLine($"Structure: {Structure}");
            Console.WriteLine($"Roof: {Roof}");
            Console.WriteLine($"Garden: {(HasGarden ? "Yes" : "No")}");
            Console.WriteLine($"Swimming Pool: {(HasSwimmingPool ? "Yes" : "No")}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
