﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Hospital.BL.ViewModels.Doctors;

public class DoctorListItemVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Image { get; set; }
}
