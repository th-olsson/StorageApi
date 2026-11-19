using System.ComponentModel.DataAnnotations;

public static class ProductRules
{
    public const int NameMinLength = 3;
    public const int NameMaxLength = 100;
    public const int PriceMinValue = 1;
    public const int PriceMaxValue = 1000000;
    public const int CategoryMinLength = 2;
    public const int CategoryMaxLength = 50;
    public const int ShelfMinLength = 2;
    public const int ShelfMaxLength = 100;
    public const int CountMinValue = 1;
    public const int CountMaxValue = 1000000;
    public const int DescriptionMinLength = 10;
    public const int DescriptionMaxLength = 200;
}

namespace StorageApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(ProductRules.NameMaxLength, MinimumLength = ProductRules.NameMinLength)]
        public string Name { get; set; }

        [Range(ProductRules.PriceMinValue, ProductRules.PriceMaxValue)]
        public int Price { get; set; }

        [StringLength(ProductRules.CategoryMaxLength, MinimumLength = ProductRules.CategoryMinLength)]
        public string Category { get; set; }

        [StringLength(ProductRules.ShelfMaxLength, MinimumLength = ProductRules.ShelfMinLength)]
        public string Shelf { get; set; }

        [Range(ProductRules.CountMinValue, ProductRules.CountMaxValue)]
        public int Count { get; set; }

        [StringLength(ProductRules.DescriptionMaxLength, MinimumLength = ProductRules.DescriptionMinLength)]
        public string Description { get; set; }
    }
}
