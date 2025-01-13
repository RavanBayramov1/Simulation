using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.BL.ViewModels.Departments;
using Hospital.BL.ViewModels.Doctors;

namespace Hospital.BL.Services.Interfaces;

public interface IDepartmentService
{
    Task CreateAsync(DepartmentCreateVM vm);
    Task UpdateAsync(DepartmentUpdateVM vm , int id);
    Task Delete(int id);
    Task<List<DepartmentListItemVM>> GetAllAsync();
}
