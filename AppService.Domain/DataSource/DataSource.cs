namespace AppService.Domain.DataSource
{
    public class DataSource
    {
        public Guid Id { get; set; }
        public string MetadataFileName { get; set; } = null!;

        public ICollection<File> Files { get; } = new List<File>();
    }
}
