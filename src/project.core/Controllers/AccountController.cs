using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Elfie.Model.Strings;
using Microsoft.EntityFrameworkCore;
using project.core.Models.DTO;

namespace project.core.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AccountController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> Index()
    {
        List<User> users = await _userManager.Users.Select(
            u => new User {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email
            }
        ).ToListAsync();

        foreach (var user in users)
        {
            user.RoleName = await _userManager.GetRolesAsync(
                await _userManager.FindByEmailAsync(user.Email)
            );
        }

        return View(users);
    }

    public IActionResult Create()
    {
        ViewData["Roles"] = _roleManager.Roles
            .ToList()
            .Select(t => new SelectListItem{
                Text = t.Name,
                Value = t.Name
            });
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Id,UserName,Email,Password,RoleName")]User model)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser { 
                UserName = model.Email, 
                Email = model.Email, 
                EmailConfirmed = true
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, model.Password);
            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                foreach (var role in model.RoleName)
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, role);
                    if (roleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    foreach (var error in roleResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
        }
        ViewData["Roles"] = _roleManager.Roles
            .ToList()
            .Select(t => new SelectListItem{
                Text = t.Name,
                Value = t.Name
            });
        return View(model);
    }

    public async Task<IActionResult> Edit(string? id)
    {
        if (id == null || _userManager.Users == null)
        {
            return NotFound();
        }

        var IdentityUser = await _userManager.Users.FirstOrDefaultAsync(m => m.Id == id);
        if (IdentityUser == null)
        {
            return NotFound();
        }
        ViewData["Roles"] = _roleManager.Roles
            .ToList()
            .Select(t => new SelectListItem{
                Text = t.Name,
                Value = t.Name
            });
        var user = new User{
            Id = IdentityUser.Id,
            UserName = IdentityUser.UserName,
            Email = IdentityUser.Email,
            RoleName = await _userManager.GetRolesAsync(IdentityUser)
        };

        return View(user);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,Email,Password,RoleName")]User model)
    {
        if (id != model.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                var user = new IdentityUser { 
                    UserName = model.Email, 
                    Email = model.Email, 
                    EmailConfirmed = true
                };
                user.NormalizedEmail = user.Email.ToUpper();
                user.NormalizedUserName = user.UserName.ToUpper();
                user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, model.Password);

                await _userManager.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                    return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
        ViewData["Roles"] = _roleManager.Roles
            .ToList()
            .Select(t => new SelectListItem{
                Text = t.Name,
                Value = t.Name
            });
        return View(User);
    }

    public async Task<IActionResult> Delete(string? id)
    {
        if (id == null || _userManager.Users == null)
        {
            return NotFound();
        }

        var IdentityUser = await _userManager.Users.FirstOrDefaultAsync(m => m.Id == id);
        if (IdentityUser == null)
        {
            return NotFound();
        }
        var user = new User{
            Id = IdentityUser.Id,
            UserName = IdentityUser.UserName,
            Email = IdentityUser.Email,
            RoleName = await _userManager.GetRolesAsync(IdentityUser)
        };

        return View(user);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(m => m.Id == id);
        if (user != null)
        {
            await _userManager.DeleteAsync(user);
        }
        return RedirectToAction(nameof(Index));
    }
}
