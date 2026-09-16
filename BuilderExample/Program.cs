var sandwich = new SandwichBuilder()
    .WithBread("integral")
    .WithFilling("queijo")
    .WithSauce("mostarda")
    .Build();

Console.WriteLine(sandwich);

sealed class Sandwich
{
    public string Bread { get; set; } = "";
    public string Filling { get; set; } = "";
    public string Sauce { get; set; } = "";

    public override string ToString() => $"Sanduíche: pão {Bread}, recheio {Filling}, molho {Sauce}";
}

sealed class SandwichBuilder
{
    private readonly Sandwich sandwich = new();

    public SandwichBuilder WithBread(string bread)
    {
        sandwich.Bread = bread;
        return this;
    }

    public SandwichBuilder WithFilling(string filling)
    {
        sandwich.Filling = filling;
        return this;
    }

    public SandwichBuilder WithSauce(string sauce)
    {
        sandwich.Sauce = sauce;
        return this;
    }

    public Sandwich Build() => sandwich;
}
