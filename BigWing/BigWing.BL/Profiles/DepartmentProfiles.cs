using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BigWing.BL.ViewModels.Clients;
using BigWing.BL.ViewModels.Departments;
using BigWing.Core.Entities;

namespace BigWing.BL.Profiles;

public class DepartmentProfiles : Profile
{
    public DepartmentProfiles()
    {
        CreateMap<DepartmentCreateVM, Department>();
        CreateMap<DepartmentUpdateVM, Department>();
        CreateMap<Department, DepartmentListItemVM>();
    }
}
