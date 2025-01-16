using BigWing.BL.Services.Implements;
using BigWing.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace BigWing.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController(DepartmentService _service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            await _service.GetAllAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
