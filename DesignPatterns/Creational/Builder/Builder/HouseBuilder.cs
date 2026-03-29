using Builder;

public class HouseBuilder
{
    private House house = new House();

    public HouseBuilder WithFoundation(string foundation)
    {
        house.Foundation = foundation;
        return this;
    }

    public HouseBuilder WithStructure(string structure)
    {
        house.Structure = structure;
        return this;
    }

    public HouseBuilder WithRoof(string roof)
    {
        house.Roof = roof;
        return this;
    }

    public HouseBuilder WithGarage(bool hasGarage)
    {
        house.HasGarage = hasGarage;
        return this;
    }

    public House Build()
    {
        return house;
    }
}