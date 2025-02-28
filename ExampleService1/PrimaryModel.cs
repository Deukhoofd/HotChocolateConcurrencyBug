namespace ExampleService1;

public record SecondaryModel
{
    public int Id { get; set; }
}

public record PrimaryModel
{
    public int Id { get; set; }
    public string Value { get; set; }
    public SecondaryModel Secondary { get; set; }
    public SecondaryModel AnotherSecondary { get; set; }
}