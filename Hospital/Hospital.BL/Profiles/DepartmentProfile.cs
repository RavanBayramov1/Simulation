using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hospital.BL.ViewModels.Departments;
using Hospital.BL.ViewModels.Doctors;
using Hospital.Core.Entities;

namespace Hospital.BL.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentCreateVM, Department>();
            CreateMap<DepartmentUpdateVM, Department>();
            CreateMap<Department, DepartmentListItemVM>();
        }
    }
}
