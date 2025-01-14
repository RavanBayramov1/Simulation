using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Plumberz.BL.ViewModels.Tecnicians;

public class TecnicianUpdateVM
{
    [MaxLength(16, ErrorMessage = "Ad 16 simvoldan çox ola bilməz!"), Required]

    public string Name { get; set; }
    [MaxLength(20, ErrorMessage = "Ad 20 simvoldan çox ola bilməz!"), Required]

    public string Surname { get; set; }
    [Required(ErrorMessage = "Fayl seçilməyib!")]
    public IFormFile ImageUrl { get; set; }
}
