namespace MyWebsite.Models
{
    // One photo in a gallery. No database: photos are listed in HomeController.
    public class Photo
    {
        public string FileName { get; set; } = "";
        public string Caption { get; set; } = "";
    }
}
