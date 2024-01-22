using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.core.Models;
using project.core.Constants;

namespace project.core.Data;

public static class ModelBuilderExtensions
{
    public static void Seed(ModelBuilder builder)
    {
        var passwordhasher = new PasswordHasher<IdentityUser>();

        var adminRole = new IdentityRole(DatabaseSeedsConstants.AdminRoleName);
        adminRole.NormalizedName = adminRole.Name.ToUpper();

        var memberRole = new IdentityRole(DatabaseSeedsConstants.UserRoleName);
        memberRole.NormalizedName = memberRole.Name.ToUpper();

        List<IdentityRole> roles = new List<IdentityRole>() {
            adminRole,
            memberRole
        };
        builder.Entity<IdentityRole>().HasData(roles);

        var superAdmin = new IdentityUser
        {
            UserName = DatabaseSeedsConstants.SuperAdminUserName,
            Email = DatabaseSeedsConstants.SuperAdminEmail,
            EmailConfirmed = true
        };

        superAdmin.NormalizedUserName = superAdmin.UserName.ToUpper();
        superAdmin.NormalizedEmail = superAdmin.Email.ToUpper();
        superAdmin.PasswordHash = passwordhasher.HashPassword(superAdmin, DatabaseSeedsConstants.SuperAdminPassword);

        var defaultUser = new IdentityUser
        {
            UserName = DatabaseSeedsConstants.DefaultUserUserName,
            Email = DatabaseSeedsConstants.DefaultUserEmail,
            EmailConfirmed = true
        };

        defaultUser.NormalizedUserName = defaultUser.UserName.ToUpper();
        defaultUser.NormalizedEmail = defaultUser.Email.ToUpper();
        defaultUser.PasswordHash = passwordhasher.HashPassword(defaultUser, DatabaseSeedsConstants.DefaultUserPassword);

        builder.Entity<IdentityUser>().HasData(superAdmin, defaultUser);

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = memberRole.Id,
                UserId = defaultUser.Id
            },
            new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = superAdmin.Id
            }
        );
    }
}
