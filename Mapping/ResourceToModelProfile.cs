using AutoMapper;
using LorikeetRESTApp.Controllers.Resources;
using LorikeetRESTApp.Core.Models;

namespace LorikeetRESTApp.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UserCredentialsResource, User>();
        }
    }
}