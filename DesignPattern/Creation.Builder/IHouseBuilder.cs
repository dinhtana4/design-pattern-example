namespace Creation.Builder
{
    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildStructure();
        void BuildRoof();
        void AddGarden();
        void AddSwimmingPool();
        House GetHouse();
    }
}
