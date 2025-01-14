using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plumberz.BL.ViewModels.Departments;
using Plumberz.BL.ViewModels.Tecnicians;

namespace Plumberz.BL.Services.Interfaces;

public interface ITecnicianService
{
    Task CreateAsync(TecnicianCreateVM vm);
    Task UpdateAsync(TecnicianUpdateVM vm, int id);
    Task Delete(int id);
    Task<List<TecnicianListItemVM>> GetAllAsync();
    Task<DepartmentListItemVM> GetByIdAsync(int id);
}
