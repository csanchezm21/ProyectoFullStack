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
        public UsuarioResponseDto? Login(UsuarioLoginDto usuarioDto)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == usuarioDto.Email);
            if (usuario == null)
            {
                return null;
            }

            bool passwordCorrecta = BCrypt.Net.BCrypt.Verify(
                usuarioDto.Password,
                usuario.PasswordHash
            );
            if (!passwordCorrecta)
            {

                return null;

            }
            return _mapper.Map<UsuarioResponseDto>(usuario);
        }
    }
}