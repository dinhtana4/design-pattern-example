namespace Creation.Builder
{
    public class BasicHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildFoundation() => _house.Foundation = "Concrete and Stone";
        public void BuildStructure() => _house.Structure = "Wood and Brick";
        public void BuildRoof() => _house.Roof = "Shingle Roof";
        public void AddGarden() => _house.HasGarden = false;
        public void AddSwimmingPool() => _house.HasSwimmingPool = false;
        public House GetHouse() => _house;
    }
}
