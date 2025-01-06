namespace Creation.Builder
{
    public class LuxuryHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildFoundation() => _house.Foundation = "Concrete, Rebar, and Stone";
        public void BuildStructure() => _house.Structure = "Steel and Glass";
        public void BuildRoof() => _house.Roof = "Solar Panel Roof";
        public void AddGarden() => _house.HasGarden = true;
        public void AddSwimmingPool() => _house.HasSwimmingPool = true;
        public House GetHouse() => _house;
    }
}
