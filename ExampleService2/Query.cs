using ExampleService1;
using GreenDonut.Data;
using HotChocolate.Execution.Processing;
using HotChocolate.Fusion.SourceSchema.Types;

namespace ExampleService2;

[QueryType]
public class Query
{
    public async Task<IReadOnlyList<SecondaryModel?>> GetSecondaryModelByIds(
        [Is("id")] IReadOnlyList<int> ids,
        ISecondaryModelsDataLoader dataLoader,
        ISelection selectorBuilder,
        CancellationToken cancellationToken)
    {
        return await dataLoader
            .Select(selectorBuilder)
            .LoadAsync(ids, cancellationToken);
    }
}