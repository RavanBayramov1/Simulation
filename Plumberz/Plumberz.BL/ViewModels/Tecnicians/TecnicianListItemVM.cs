using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Plumberz.BL.ViewModels.Tecnicians;

public class TecnicianListItemVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
}
