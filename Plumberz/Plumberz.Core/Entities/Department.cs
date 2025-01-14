using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.Core.Entities;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Tecnician> Tecnicians { get; set; }
}
