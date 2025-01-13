using AutoMapper;
using Hospital.BL.Services.Interfaces;
using Hospital.BL.ViewModels.Doctors;
using Hospital.Core.Entities;
using Hospital.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Hospital.BL.Services.Implements;

public class DoctorService(HospitalDbContext _context, IMapper _mapper) : IDoctorService
{
    public async Task<List<DoctorListItemVM>> GetAllAsync()
    {
        var doctor = await _context.Doctors.ToListAsync();
        return _mapper.Map<List<DoctorListItemVM>>(doctor);

    }
    public async Task CreateAsync(DoctorCreateVM vm)
    {
        var doctor = _mapper.Map<Doctor>(vm);
        await _context.AddAsync(doctor);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(DoctorUpdateVM vm, int id)
    {
        var doctor = await _context.Doctors.Where(x=>x.Id==id).FirstOrDefaultAsync();
        _mapper.Map(vm, doctor);
        await _context.SaveChangesAsync();
    }
    public async Task Delete(int id)
    {
        var doctor = await _context.Doctors.Where(x => x.Id == id).FirstOrDefaultAsync();
        _context.Doctors.Remove(doctor);
        await _context.SaveChangesAsync();
    }
}
