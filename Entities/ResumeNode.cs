namespace Portfolio.Entities
{
    public class ResumeNode
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Years { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string List { get; set; }
        public ResumeType Type { get; set; }
    }

    public enum ResumeType
    {
        Summary, Education, ProfExp
    }
}
