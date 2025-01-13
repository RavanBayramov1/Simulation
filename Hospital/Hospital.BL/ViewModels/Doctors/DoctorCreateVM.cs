using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Hospital.BL.ViewModels.Doctors;

public class DoctorCreateVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public IFormFile Image { get; set; }
}
