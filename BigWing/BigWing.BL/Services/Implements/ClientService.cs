using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BigWing.BL.Extensions;
using BigWing.BL.Services.Interfaces;
using BigWing.BL.ViewModels.Clients;
using BigWing.Core.Entities;
using BigWing.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace BigWing.BL.Services.Implements;

public class ClientService(BigWingDbContext _context, IMapper _mapper ) : IClientService
{
    public async Task<List<ClientListItemVM>> GetAllAsync()
    {
        var client = await _context.Clients.Include(x=>x.Department).ToListAsync();
        return _mapper.Map<List<ClientListItemVM>>(client);
    }
    public async Task CreateAsync(ClientCreateVM vm , string path)
    {
        var client = await _context.Clients.Where(x=>x.FullName==vm.FullName).FirstOrDefaultAsync();
        if (client is not null) throw new Exception();
        client = _mapper.Map<Client>(vm);
        client.Image = await vm.ImageUrl.UploadAsync(path);
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(ClientUpdateVM vm, int? id, string path)
    {
        var client = await _context.Clients.FindAsync(id);
        if (client is null) throw new Exception();
        _mapper.Map(vm,client);
        client.Image = await vm.ImageUrl.UploadAsync(path);
        await _context.SaveChangesAsync();
    }
    public async Task Delete(int? id)
    {
        var client = await _context.Clients.FindAsync(id);
        if(client is null) throw new Exception();
        _context.Clients.Remove(client);
        await _context.SaveChangesAsync();
    }
}
