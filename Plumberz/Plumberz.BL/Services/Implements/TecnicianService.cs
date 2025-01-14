using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Plumberz.BL.Services.Interfaces;
using Plumberz.BL.ViewModels.Departments;
using Plumberz.BL.ViewModels.Tecnicians;
using Plumberz.Core.Entities;
using Plumberz.DAL.Context;

namespace Plumberz.BL.Services.Implements;

public class TecnicianService(PlumberzDbContext _context,IMapper _mapper) : ITecnicianService
{
    public async Task CreateAsync(TecnicianCreateVM vm)
    {
        var department = _mapper.Map<Tecnician>(vm);
        await _context.SaveChangesAsync();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<TecnicianListItemVM>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DepartmentListItemVM> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TecnicianUpdateVM vm, int id)
    {
        throw new NotImplementedException();
    }
}
