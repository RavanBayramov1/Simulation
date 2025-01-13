using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Core.Entities;

public class Doctor : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Image { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

}
