using AutoMapper;
using ProyectoFullStack.API.Data;
using ProyectoFullStack.API.DTOs;
using ProyectoFullStack.API.Interfaces;
using ProyectoFullStack.API.Models;


namespace ProyectoFullStack.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UsuarioService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public UsuarioResponseDto CrearUsuario(UsuarioCreateDto usuarioDto)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDto);

            usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(usuarioDto.Password);

            usuario.Rol = "Usuario";

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return _mapper.Map<UsuarioResponseDto>(usuario);
        }
    }
}