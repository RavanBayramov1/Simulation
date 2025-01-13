using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hospital.BL.ViewModels.Doctors;
using Hospital.Core.Entities;

namespace Hospital.BL.Profiles;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<DoctorCreateVM,Doctor>();
        CreateMap<DoctorUpdateVM, Doctor>();
        CreateMap<Doctor, DoctorListItemVM>();
    }
}
