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
        private readonly IJwtService _jwtService;

        public UsuarioService(
            ApplicationDbContext context,
            IMapper mapper,
            IJwtService jwtService)
        {
            _context = context;
            _mapper = mapper;
            _jwtService = jwtService;
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

        public LoginResponseDto? Login(UsuarioLoginDto usuarioDto)
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

            var token = _jwtService.GenerarToken(usuario);

            var usuarioResponse = _mapper.Map<UsuarioResponseDto>(usuario);

            return new LoginResponseDto
            {
                Token = token,
                Usuario = usuarioResponse
            };
        }
    }
}