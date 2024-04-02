namespace AppService.Domain.DataSource
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public Guid DataSourceId { get; set; }
        public DataSource DataSource { get; set; } = null!;
    }
}
