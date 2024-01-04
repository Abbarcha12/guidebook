namespace Guidebooks.Api.Models
{
    public class Guidebook
    {
        public int Id { get; set; }
        public string Header {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
