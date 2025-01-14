using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.ViewModels.Departments;

public class DepartmentCreateVM
{
    [MaxLength(64, ErrorMessage = "Ad 64 simvoldan çox ola bilməz!"), Required]
    public string Name { get; set; }
}
