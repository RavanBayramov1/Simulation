using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigWing.BL.ViewModels.Clients;
using BigWing.BL.ViewModels.Departments;

namespace BigWing.BL.Services.Interfaces;

public interface IClientService
{
    Task<List<ClientListItemVM>> GetAllAsync();
    Task CreateAsync(ClientCreateVM vm,string path);
    Task UpdateAsync(ClientUpdateVM vm, int? id, string path);
    Task Delete(int? id);
}
