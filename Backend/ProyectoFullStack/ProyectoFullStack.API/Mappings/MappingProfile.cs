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
        }
    }
}
