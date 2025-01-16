using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BigWing.BL.ViewModels.Clients;

public class ClientListItemVM
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Comment { get; set; }
    public int DepartmentId { get; set; }
}
