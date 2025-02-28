namespace ExampleService1;

public static class ExampleDataLoader
{
    [DataLoader]
    public static async Task<Dictionary<int, PrimaryModel>> GetPrimaryModels(
        IReadOnlyList<int> ids, CancellationToken cancellationToken)
    {
        return ids.ToDictionary(x => x, x =>
            new PrimaryModel
            {
                Id = x,
                Value = "Value" + x,
                Secondary = new SecondaryModel
                {
                    Id = x
                },
                AnotherSecondary = new SecondaryModel
                {
                    Id = x + 1
                }
            }
        );
    }
}