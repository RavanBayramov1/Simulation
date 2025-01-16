using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigWing.Core.Entities;

public class Client : BaseEntity
{
    public string FullName { get; set; }
    public string Image { get; set; }
    public string Comment { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}
