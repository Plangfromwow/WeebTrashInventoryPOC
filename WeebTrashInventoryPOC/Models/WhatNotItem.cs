using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace WeebTrashInventoryPOC.Models
{
    internal class WhatNotItem
    {
        [Name("Category")]
        public string Category { get; set; }
        [Name("Sub Category")]
        public string SubCategory { get; set; }
        [Name("Title")]
        public string Title { get; set; }
        [Name("Description")]
        public string Description { get; set; }
        [Name("Quantity")]
        public string Quantity { get; set; }
        [Name("Type")]
        public string WhatNotType { get; set; }
        [Name("Price")]
        public string Price { get; set; }
        [Name("Shipping Profile")]
        public string ShippingProfile { get; set; }
        [Name("Gradable")]
        public string Gradable { get; set; } = "False";
        [Name("Offerable")]
        public string Offerable { get; } = "False";
        [Name("Hazmat")]
        public string Hazmat { get; } = "Not Hazmat";
        [Name("Image URL 1")]
        public string ImageURL1 { get; set; }
        [Name("Image URL 2")]
        public string ImageURL2 { get; set; }
        [Name("Image URL 3")]
        public string ImageURL3 { get; set; }
        [Name("Image URL 4")]
        public string ImageURL4 { get; set; }


        public override string ToString()
        {
            return $"Whatnot Item: {Title} {Description} {Category} {SubCategory} {Price} {ShippingProfile} ";
        }
    }
}
