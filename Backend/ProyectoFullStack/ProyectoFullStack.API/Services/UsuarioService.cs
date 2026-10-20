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


        public (UsuarioResponseDto? Usuario, bool EmailExiste) CrearUsuario(
            UsuarioCreateDto usuarioDto)
        {
            var email = usuarioDto.Email.Trim();

            // Comprobar si el correo ya está registrado.
            bool emailExiste = _context.Usuarios
                .Any(u => u.Email == email);

            if (emailExiste)
            {
                return (null, true);
            }

            // Crear el usuario con los datos recibidos.
            var usuario = _mapper.Map<Usuario>(usuarioDto);

            usuario.Nombre = usuario.Nombre.Trim();
            usuario.Email = email;

            // Guardar la contraseña como hash, nunca como texto normal.
            usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(
                usuarioDto.Password
            );

            // El rol lo asigna el servidor.
            usuario.Rol = "Usuario";

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            var usuarioResponse = _mapper.Map<UsuarioResponseDto>(usuario);

            return (usuarioResponse, false);
        }


        public LoginResponseDto? Login(UsuarioLoginDto usuarioDto)
        {
            var email = usuarioDto.Email.Trim();

            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email);

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