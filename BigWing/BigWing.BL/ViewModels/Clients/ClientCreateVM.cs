using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BigWing.BL.ViewModels.Clients;

public class ClientCreateVM
{
    [MaxLength(32, ErrorMessage = "Ad,Soyad 32 simvoldan çox ola bilməz!"), Required]
    public string FullName { get; set; }
    [MaxLength(512, ErrorMessage = "Komment 512 simvoldan çox ola bilməz!"), Required]
    public string Comment { get; set; }
    [Required(ErrorMessage ="Fayl Secin")]
    public IFormFile ImageUrl { get; set; }
    public int DepartmentId { get; set; }
}
