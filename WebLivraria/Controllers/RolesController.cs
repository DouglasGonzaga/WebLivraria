using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebLivraria.Data;

namespace WebLivraria.Controllers
{
    public class RolesController : Controller
    {
        ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        public RolesController(ApplicationDbContext context,RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _context.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            var role = new IdentityRole();
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            IdentityResult roleResult = await _roleManager.CreateAsync(new IdentityRole(role.Name));
            return RedirectToAction("Index");
        }
    }
}