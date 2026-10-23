using AutoMapper;
using ProyectoFullStack.API.DTOs;
using ProyectoFullStack.API.Models;


namespace ProyectoFullStack.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap <Producto, ProductoResponseDto>();

            CreateMap <ProductoCreateDto, Producto>();

            CreateMap <ProductoUpdateDto, Producto>();

            CreateMap<UsuarioCreateDto, Usuario>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Rol, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
            CreateMap <Usuario, UsuarioResponseDto>();
        }
    }
}
