namespace ExampleService1;

public record TertiaryModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public record SecondaryModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TertiaryModel Tertiary { get; set; }
}