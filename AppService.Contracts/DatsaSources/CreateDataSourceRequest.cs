namespace AppService.Contracts.DatsaSources
{
    public record CreateDataSourceRequest
    {
        public IEnumerable<CategoryFilePair> FileCategory = Enumerable.Empty<CategoryFilePair>();
    }
}
