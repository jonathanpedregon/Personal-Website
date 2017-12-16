namespace JonathanPedregon.Models
{
    public class SiteViewModel
    {
        public string ImagePath { get; set; }
        public string SiteName { get; set; }
        public string CreationDate { get; set; }
        public string Description { get; set; }

        public SiteViewModel(string imagePage, string siteName, string creationDate, string description)
        {
            ImagePath = imagePage;
            SiteName = siteName;
            CreationDate = creationDate;
            Description = description;
        }
    }
}