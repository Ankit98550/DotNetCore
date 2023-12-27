using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EntityFrameWorkcodeFirstApproch.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions db):base (db)
        {
            
        }
        
        public DbSet<student> Students { get; set; }
    }
}
