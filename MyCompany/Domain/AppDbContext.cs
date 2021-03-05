using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entitites;

namespace MyCompany.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id="ffa04c34-fb37-4b74-9531-ca2ed2d15fd0",
                Name="admin",
                NormalizedName = "ADMIN"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "f153a1c4-e832-439f-b610-9690855e1792",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email ="my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null,"superpassword"),
                SecurityStamp = string.Empty
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "ffa04c34-fb37-4b74-9531-ca2ed2d15fd0",
                UserId = "f153a1c4-e832-439f-b610-9690855e1792"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("7da8eae2-8610-41b1-b68f-ca408057156b"),
                CodeWord = "PageIndex",
                Title = "Main"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("7cb37c12-0eee-45a8-bab1-4d24f472075a"),
                CodeWord = "PageServices",
                Title = "Our services"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("877e92c3-71d2-44fa-8aef-7a4201d36afe"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });

        }
    }
}
