namespace Catalog.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public int? Rating { get; set; }
        public int? Stock  { get; set; }


        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //Navigation Property
        public Category Category { get; set; }

        public int CategoryId { get; set; }

    }
}
