using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hospital.BL.Services.Interfaces;
using Hospital.BL.ViewModels.Departments;
using Hospital.BL.ViewModels.Doctors;
using Hospital.Core.Entities;
using Hospital.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Hospital.BL.Services.Implements;

public class DepartmentService(HospitalDbContext _context, IMapper _mapper) : IDepartmentService
{
    public async Task<List<DepartmentListItemVM>> GetAllAsync()
    {
        var department = await _context.Departments.ToListAsync();
        return _mapper.Map<List<DepartmentListItemVM>>(department);
    }
    public async Task CreateAsync(DepartmentCreateVM vm)
    {
        var department = _mapper.Map<Department>(vm);
        await _context.AddAsync(department);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(DepartmentUpdateVM vm, int id)
    {
        var department = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
        _mapper.Map(vm, department);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var department = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();
    }


}
