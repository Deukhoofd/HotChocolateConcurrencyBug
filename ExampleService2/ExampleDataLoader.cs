using GreenDonut.Data;

namespace ExampleService1;

public static class ExampleDataLoader
{
    [DataLoader]
    public static async Task<Dictionary<int, SecondaryModel>> GetSecondaryModels(
        IReadOnlyList<int> ids,
        ISelectorBuilder selectorBuilder,
        CancellationToken cancellationToken)
    {
        return ids.Select(x => new SecondaryModel
        {
            Id = x,
            Name = "Secondary" + x,
            Tertiary = new TertiaryModel
            {
                Id = x,
                Name = "Tertiary" + x
            }
        })
        .AsQueryable()
        .Select(x => x.Id, selectorBuilder)
        .ToDictionary(x => x.Id, x => x);
    }
}