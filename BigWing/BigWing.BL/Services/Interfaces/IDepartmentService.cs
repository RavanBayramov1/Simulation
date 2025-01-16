using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigWing.BL.ViewModels.Departments;

namespace BigWing.BL.Services.Interfaces;

public interface IDepartmentService
{
    Task<List<DepartmentListItemVM>> GetAllAsync();
    Task CreateAsync(DepartmentCreateVM vm);
    Task UpdateAsync(DepartmentUpdateVM vm,int? id);
    Task Delete(int? id);
}
