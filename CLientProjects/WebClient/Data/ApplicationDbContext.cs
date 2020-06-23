using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebClient.Models;


namespace WebClient.Data
{
   public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder model)
            {
                base.OnModelCreating(model);
                model.Entity<ApplicationUser>(user => user.HasIndex(x => x.Local).IsUnique(false));
                model.Entity<organization>(org =>
                {
                    org.ToTable("Organizations");
                    org.HasKey(x => x.Id);
                    org.HasMany<ApplicationUser>().WithOne().HasForeignKey(x => x.OrgId).IsRequired(false);
                });
            }
        }
  
}
