/*var myHouse = House.Builder()
                   .Rooms(4)
                   .Bathrooms(2)
                   .HasGarage(true)
                   .HasGarden(false)
                   .Build();

Console.WriteLine($"Rooms: {myHouse.Rooms}, Bathrooms: {myHouse.Bathrooms}, Garage: {myHouse.HasGarage}, Garden: {myHouse.HasGarden}");
*/
public class House
{
    public int Rooms { get; }
    public int Bathrooms { get; }
    public bool HasGarage { get; }
    public bool HasGarden { get; }

    private House(int rooms, int bathrooms, bool hasGarage, bool hasGarden)
    {
        Rooms = rooms;
        Bathrooms = bathrooms;
        HasGarage = hasGarage;
        HasGarden = hasGarden;
    }

    public static HouseBuilder Builder() => new HouseBuilder();

    public class HouseBuilder
    {
        private int _rooms;
        private int _bathrooms;
        private bool _hasGarage;
        private bool _hasGarden;

        public HouseBuilder Rooms(int rooms) { _rooms = rooms; return this; }
        public HouseBuilder Bathrooms(int bathrooms) { _bathrooms = bathrooms; return this; }
        public HouseBuilder HasGarage(bool hasGarage) { _hasGarage = hasGarage; return this; }
        public HouseBuilder HasGarden(bool hasGarden) { _hasGarden = hasGarden; return this; }

        public House Build() => new House(_rooms, _bathrooms, _hasGarage, _hasGarden);
    }
}
