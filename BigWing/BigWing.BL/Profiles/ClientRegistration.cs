using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BigWing.BL.ViewModels.Clients;
using BigWing.Core.Entities;

namespace BigWing.BL.Profiles;

public class ClientRegistration : Profile
{
    public ClientRegistration()
    {
        CreateMap<ClientCreateVM, Client>();
        CreateMap<ClientUpdateVM, Client>();
        CreateMap<Client, ClientListItemVM>();
    }
}
