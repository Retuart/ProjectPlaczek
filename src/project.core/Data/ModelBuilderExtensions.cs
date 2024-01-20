using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.core.Models;

namespace project.core.Data;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder builder)
    {
        string pwd = "admin";
        var passwordhasher = new PasswordHasher<IdentityUser>();

        var adminRole = new IdentityRole("admin");
        adminRole.NormalizedName = adminRole.Name.ToUpper();

        var memberRole = new IdentityRole("member");
        memberRole.NormalizedName = memberRole.Name.ToUpper();

        List<IdentityRole> roles = new List<IdentityRole>() {
            adminRole,
            memberRole
        };
        builder.Entity<IdentityRole>().HasData(roles);

        var superAdmin = new IdentityUser
        {
            UserName = "superadmin@localhost",
            Email = "superadmin@localhost",
            EmailConfirmed = true
        };

        superAdmin.NormalizedUserName = superAdmin.UserName.ToUpper();
        superAdmin.NormalizedEmail = superAdmin.Email.ToUpper();
        superAdmin.PasswordHash = passwordhasher.HashPassword(superAdmin, pwd);

        builder.Entity<IdentityUser>().HasData(superAdmin);

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = superAdmin.Id
            }
        );
    }
}
