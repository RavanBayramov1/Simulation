using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plumberz.BL.Services.Interfaces;
using Plumberz.BL.ViewModels.Departments;

namespace Plumberz.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DepartmentController(IDepartmentService _service) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await _service.GetAllAsync());
        
    }
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(DepartmentCreateVM vm)
    {
        return View(_service.CreateAsync(vm));
    }
    public async Task<IActionResult> Update(int? id)
    {
        if (id is null) return BadRequest();
        return View(_service.GetByIdAsync(id));
    }
    [HttpPost]
    public async Task<IActionResult> Update(DepartmentUpdateVM vm , int id)
    {
        return View(_service.UpdateAsync(vm, id));
    }
    public async Task<IActionResult> Delete(int id)
    {
        return View(_service.Delete(id));
    }
}
