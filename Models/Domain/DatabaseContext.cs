using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Yt_Dot6Identity.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        // public object NurseRequests { get; internal set; }
        public DbSet<Department> Departments {get; set;}
        public DbSet<JobStatus> JobStatuses {get; set;}
        public DbSet<Material> Materials {get; set;}
        public DbSet<MaterialStatus> MaterialStatuses {get; set;}
        public DbSet<NurseRequest> NurseRequest {get; set;}
        public DbSet<Patient> Patients {get; set;}
        public DbSet<Poter> Poters {get; set;}
        public DbSet<Urgent> Urgents {get; set;}
        public DbSet<UserLogin> UserLogins {get; set;}
        public DbSet<UserRole> UserRoles {get; set;}
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Poter>().HasData(
        //         new Poter
        //         {
        //             Id  = 1,
        //             EmpId  = 402,
        //             PoterFname  = "นายไพโรจน์",
        //             PoterLname = "ชาวไร่อ้อย"
        //         },
        //         new Poter
        //         {
        //             Id  = 2,
        //             EmpId  = 403,
        //             PoterFname  = "นายปรีชา",
        //             PoterLname = "ยี่อินทร"
        //         },
        //         new Poter
        //         {
        //             Id  = 3,
        //             EmpId  = 419,
        //             PoterFname  = "นายรณรงค์",
        //             PoterLname = "มาลามาศ"
        //         }
        //     );
        // }
        
    }
}
