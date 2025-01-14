using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plumberz.BL.ViewModels.Departments;

namespace Plumberz.BL.Services.Interfaces;

public interface IDepartmentService
{
    Task CreateAsync(DepartmentCreateVM vm);
    Task UpdateAsync(DepartmentUpdateVM vm, int id);
    Task Delete(int id);
    Task<List<DepartmentListItemVM>> GetAllAsync();
    Task<DepartmentListItemVM> GetByIdAsync(int? id);
}
