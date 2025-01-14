using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Plumberz.BL.Exceptions.Common;
using Plumberz.BL.Services.Interfaces;
using Plumberz.BL.ViewModels.Departments;
using Plumberz.Core.Entities;
using Plumberz.DAL.Context;

namespace Plumberz.BL.Services.Implements;

public class DepartmentService(PlumberzDbContext _context, IMapper _mapper) : IDepartmentService
{
    public async Task<List<DepartmentListItemVM>> GetAllAsync()
    {
        var department = await _context.Departments.ToListAsync();
        return _mapper.Map<List<DepartmentListItemVM>>(department);
    }
    public async Task CreateAsync(DepartmentCreateVM vm)
    {
        if (await _context.Departments.AnyAsync(x => x.Name == vm.Name))
            throw new ExistException<Department>();
        var department = _mapper.Map<DepartmentCreateVM>(vm);
        await _context.AddAsync(department);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DepartmentUpdateVM vm, int id)
    {
        var department = await _context.Departments.FindAsync(id);
        if (department is null) throw new NotFoundException<Department>();
        _mapper.Map(vm, department);
        await _context.SaveChangesAsync();
    }
    public async Task Delete(int id)
    {
        var department = await _context.Departments.FindAsync(id);
        if (department is null) throw new NotFoundException<Department>();
        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();

    }

    public async Task<DepartmentListItemVM> GetByIdAsync(int? id)
    {
        var department = await _context.Departments.FindAsync(id);
        var data = _mapper.Map<DepartmentListItemVM>(department);
        return data;
    }
}
