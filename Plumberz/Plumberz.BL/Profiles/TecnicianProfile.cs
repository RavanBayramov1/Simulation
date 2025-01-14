using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Plumberz.BL.ViewModels.Departments;
using Plumberz.BL.ViewModels.Tecnicians;
using Plumberz.Core.Entities;

namespace Plumberz.BL.Profiles;

public class TecnicianProfile : Profile
{
    public TecnicianProfile()
    {
        CreateMap<TecnicianCreateVM, Tecnician>();
        CreateMap<TecnicianUpdateVM, Tecnician>();
        CreateMap<Tecnician, TecnicianListItemVM>();
    }
}
