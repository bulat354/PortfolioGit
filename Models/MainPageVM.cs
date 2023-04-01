using Microsoft.EntityFrameworkCore;
using Portfolio.Entities;

namespace Portfolio.Models
{
    public class MainPageVM : PortfolioVMBase
    {
        public List<MainInfo> MainInfos { get; set; }
        public List<NumberFact> Numbers { get; set; }
        public List<SkillInfo> Skills { get; set; }
        public List<ResumeNode> ResumeNodes { get; set; }
        public List<PortfolioProject> PortfolioProjects { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<ContactInfo> Contacts { get; set; }
    }
}
