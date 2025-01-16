using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigWing.BL.ViewModels.Departments;

public class DepartmentCreateVM
{
    [MaxLength(32,ErrorMessage = "Ad 32 simvoldan çox ola bilməz!"),Required]
    public string Name { get; set; }
}
