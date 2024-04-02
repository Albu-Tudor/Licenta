namespace AppService.Contracts.DatsaSources
{
    public record CreateDataSourceRequest(IEnumerable<CategoryFilePair> FileCategory);
}
