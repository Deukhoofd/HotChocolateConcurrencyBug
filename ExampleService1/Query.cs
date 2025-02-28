namespace ExampleService1;

[QueryType]
public class Query
{
    public async Task<PrimaryModel?> GetPrimaryModel(int id, IPrimaryModelsDataLoader dataLoader)
    {
        return await dataLoader.LoadAsync(id);
    }
}