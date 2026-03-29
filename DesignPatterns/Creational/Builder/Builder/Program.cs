var house = new HouseBuilder()
    .WithFoundation("Concrete")
    .WithStructure("Wood")
    .WithRoof("Shingles")
    .WithGarage(true)
    .Build();

Console.WriteLine(house);