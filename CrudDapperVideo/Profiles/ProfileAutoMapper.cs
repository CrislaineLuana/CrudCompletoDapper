using AutoMapper;
using CrudDapperVideo.Dto;
using CrudDapperVideo.Models;

namespace CrudDapperVideo.Profiles
{
    public class ProfileAutoMapper : Profile
    {

        public ProfileAutoMapper()
        {
            CreateMap<Usuario, UsuarioListarDto>();
        }

    }
}
