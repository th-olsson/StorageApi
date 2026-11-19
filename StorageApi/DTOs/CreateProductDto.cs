using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs
{
    public class CreateProductDto
    {
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
