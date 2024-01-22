using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.core.Data;
using project.core.Models;
using Microsoft.AspNetCore.Identity;

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

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(User model)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true};
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, model.RoleName);
                if (roleResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in roleResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
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
        
        return View(model);
    }
    public async Task<IActionResult> MakeMeAdmin()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user != null && !await _userManager.IsInRoleAsync(user, "Admin"))
        {
            var result = await _userManager.AddToRoleAsync(user, "Admin");
            if (result.Succeeded)
            {
                // Opcjonalnie: Dodaj logikę po pomyślnym przypisaniu roli
            }
            else
            {
                // Opcjonalnie: Obsługa błędów
            }
        }

        return RedirectToAction("Index", "Home"); // Zmień, jeśli potrzebujesz
    }
  
}
