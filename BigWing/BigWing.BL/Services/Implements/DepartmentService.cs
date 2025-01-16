using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BigWing.BL.Services.Interfaces;
using BigWing.BL.ViewModels.Departments;
using BigWing.Core.Entities;
using BigWing.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace BigWing.BL.Services.Implements;

public class DepartmentService(BigWingDbContext _context,IMapper _mapper) : IDepartmentService
{
    public async Task<List<DepartmentListItemVM>> GetAllAsync()
    {
        var department = await _context.Departments.ToListAsync();
        return _mapper.Map<List<DepartmentListItemVM>>(department);
    }
    public async Task CreateAsync(DepartmentCreateVM vm)
    {
        var department = await _context.Departments.Where(x => x.Name == vm.Name).FirstOrDefaultAsync();
        if (department is not null) throw new Exception();
        department = _mapper.Map<Department>(vm);
        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(DepartmentUpdateVM vm, int? id)
    {
        var department = await _context.Departments.FindAsync(id);
        if(department is null) throw new Exception();
        _mapper.Map(vm, department);
        await _context.SaveChangesAsync();
    }
    public async Task Delete(int? id)
    {
        var department = await _context.Departments.FindAsync(id);
        if(department is null) throw new Exception();
        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();
    }

}
