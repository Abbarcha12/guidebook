using System.Collections.Generic;

namespace Guidebooks.Api.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public IEnumerable<string> ImageUrls { get; set; }
        public string Address { get; set; }
        public string WebsiteUrl { get; set; }
        public int GuidebookId { get; set; }
        public int CategoryId { get; set; }
    }
}
