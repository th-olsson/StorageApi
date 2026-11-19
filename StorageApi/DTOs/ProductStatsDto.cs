namespace StorageApi.DTOs
{
    public class ProductStatsDto
    {
        public int TotalProducts { get; set; }
        public int TotalInventoryValue { get; set; }
        public int AveragePrice { get; set; }
    }
}
