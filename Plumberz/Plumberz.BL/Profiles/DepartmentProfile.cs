using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Plumberz.BL.ViewModels.Departments;
using Plumberz.Core.Entities;

namespace Plumberz.BL.Profiles;

public class DepartmentProfile: Profile
{
    public DepartmentProfile()
    {
        CreateMap<DepartmentCreateVM, Department>();
        CreateMap<DepartmentUpdateVM, Department>();
        CreateMap<Department, DepartmentListItemVM>();
    }
}
