namespace Creation.Builder
{
    public class HouseDirector
    {
        private readonly IHouseBuilder _builder;

        public HouseDirector(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructHouse()
        {
            _builder.BuildFoundation();
            _builder.BuildStructure();
            _builder.BuildRoof();
            _builder.AddGarden();
            _builder.AddSwimmingPool();
        }

        public House GetHouse() => _builder.GetHouse();
    }
}
