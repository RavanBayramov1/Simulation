using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.BL.ViewModels.Doctors;

namespace Hospital.BL.Services.Interfaces;

public interface IDoctorService
{
    Task CreateAsync(DoctorCreateVM vm);
    Task UpdateAsync(DoctorUpdateVM vm, int id);
    Task Delete(int id);
    Task<List<DoctorListItemVM>> GetAllAsync();
}
