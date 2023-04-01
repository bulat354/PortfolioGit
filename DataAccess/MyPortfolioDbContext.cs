using Microsoft.EntityFrameworkCore;
using Portfolio.Entities;

namespace Portfolio.DataAccess
{
    public class MyPortfolioDbContext : DbContext
    {
        public DbSet<MainInfo> MainInfos { get; set; }
        public DbSet<NumberFact> Numbers { get; set; }
        public DbSet<SkillInfo> Skills { get; set; }
        public DbSet<ResumeNode> ResumeNodes { get; set; }
        public DbSet<PortfolioProject> PortfolioProjects { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ContactInfo> Contacts { get; set; }
        public DbSet<ContactLink> Links { get; set; }

        public MyPortfolioDbContext(DbContextOptions<MyPortfolioDbContext> options) : base(options) 
        { 
        
        }
    }
}
