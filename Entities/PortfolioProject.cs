namespace Portfolio.Entities
{
    public class PortfolioProject
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ImageSrc { get; set; }
        public ProjectType Category { get; set; }
    }

    public enum ProjectType
    {
        App, Card, Web
    }
}
