# 🚀 Proyecto Full Stack — ASP.NET Core Web API + SQL Server + Angular

Proyecto personal de desarrollo Full Stack enfocado en la construcción de una aplicación web con **C#, ASP.NET Core Web API, SQL Server y Angular**.

El objetivo es aplicar buenas prácticas de desarrollo, arquitectura por capas, persistencia de datos, autenticación y seguridad, construyendo progresivamente un proyecto para mi portafolio profesional como desarrollador de software.

**Estado actual:** Backend en desarrollo, con CRUD de productos, registro de usuarios y autenticación JWT implementados. La integración con Angular está pendiente.

---

## 📌 Tabla de contenido

- [Tecnologías](#-tecnologías)
- [Funcionalidades implementadas](#-funcionalidades-implementadas)
- [Arquitectura](#-arquitectura)
- [Base de datos](#-base-de-datos)
- [Requisitos previos](#-requisitos-previos)
- [Instalación y ejecución](#-instalación-y-ejecución)
- [Pruebas de la API](#-pruebas-de-la-api)
- [Próximas mejoras](#-próximas-mejoras)
- [Autor](#-autor)

---

## 🛠️ Tecnologías

### Backend

- C#
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- AutoMapper
- BCrypt para el hash de contraseñas
- JWT Bearer Authentication
- Data Annotations para validaciones
- ILogger para registro de eventos
- Middleware para manejo global de excepciones

### Base de datos

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Entity Framework Core Code First
- Migraciones de base de datos
- Índices únicos para restricciones de integridad

### Herramientas

- Visual Studio 2022
- Swagger / OpenAPI
- Git
- GitHub
- Visual Studio Code

### Frontend — planificado

- Angular
- TypeScript
- HTML5
- CSS3
- Bootstrap

---

## ✅ Funcionalidades implementadas

### 📦 Gestión de productos

- Consultar todos los productos.
- Consultar un producto por su identificador.
- Crear productos.
- Actualizar productos.
- Eliminar productos.
- Validar los datos recibidos mediante DTOs.
- Utilizar AutoMapper para transformar objetos.
- Manejar errores y registrar eventos mediante logging.
- Mantener un formato consistente en las respuestas de la API.

### 👤 Registro de usuarios

- Registrar usuarios mediante un endpoint de la API.
- Validar nombre, correo electrónico y contraseña.
- Comprobar si el correo ya está registrado.
- Almacenar las contraseñas utilizando BCrypt, sin guardarlas en texto plano.
- Asignar el rol inicial `Usuario`.
- Devolver respuestas HTTP apropiadas para registros exitosos, datos inválidos y correos duplicados.
- Aplicar un índice único sobre el correo electrónico en SQL Server.

### 🔐 Autenticación JWT

- Iniciar sesión mediante correo electrónico y contraseña.
- Verificar contraseñas mediante BCrypt.
- Generar tokens JWT para usuarios autenticados.
- Validar la firma, el emisor, la audiencia y la vigencia del token.
- Proteger endpoints mediante `[Authorize]`.
- Probar los endpoints desde Swagger utilizando Bearer Token.

### 🧱 Buenas prácticas

- Arquitectura por capas.
- Separación de responsabilidades mediante interfaces y servicios.
- Uso de DTOs para las entradas y salidas de la API.
- Validaciones de datos.
- Respuestas consistentes mediante `ApiResponseDto<T>`.
- Manejo global de excepciones.
- Logging.
- Control de versiones con Git y GitHub.

---

## 🏗️ Arquitectura

El backend utiliza una arquitectura por capas para separar las responsabilidades y facilitar el mantenimiento.

```text
ProyectoFullStack/
│
├── Backend/
│   └── ProyectoFullStack/
│       └── ProyectoFullStack.API/
│           ├── Controllers/
│           ├── Services/
│           ├── Interfaces/
│           ├── Data/
│           ├── Models/
│           ├── DTOs/
│           ├── Middleware/
│           ├── Mapping/
│           ├── Program.cs
│           └── appsettings.json
│
├── Frontend/          # Integración con Angular planificada
├── BaseDatos/         # Documentación y recursos de SQL Server
├── Documentacion/     # Documentación técnica del proyecto
└── README.md
```

> La estructura muestra la organización prevista del proyecto. Algunas carpetas pueden incorporarse a medida que avance el desarrollo.

### Flujo de la aplicación

```text
Cliente / Swagger
       |
       v
   Controller
       |
       v
     Service
       |
       v
ApplicationDbContext
       |
       v
    SQL Server
```

Los DTOs permiten controlar los datos que recibe y devuelve la API. El middleware gestiona las excepciones no controladas y el sistema de logging registra eventos relevantes.

---

## 🗄️ Base de datos

La aplicación utiliza SQL Server y Entity Framework Core.

### Entidades principales

**Producto**

- `Id`
- `Nombre`
- `Precio`
- `Stock`

**Usuario**

- `Id`
- `Nombre`
- `Email`
- `PasswordHash`
- `Rol`

La tabla de usuarios cuenta con un índice único sobre `Email` para impedir registros duplicados con el mismo valor de correo.

La contraseña se almacena como hash generado mediante BCrypt; no se debe almacenar ni exponer la contraseña original.

---

## 💻 Requisitos previos

Antes de ejecutar el backend, instala:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads)
- [SQL Server Management Studio](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- Git

---

## ⚙️ Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/csanchezm21/ProyectoFullStack.git
```

Entrar en la carpeta del proyecto:

```bash
cd ProyectoFullStack
```

### 2. Configurar SQL Server

Crea o configura una instancia de SQL Server y prepara la cadena de conexión para la base de datos `ProyectoFullStackDB`.

Configura la conexión en los ajustes locales de la aplicación. No publiques contraseñas, claves privadas ni credenciales reales en GitHub.

### 3. Configurar JWT

Configura los valores requeridos por la aplicación para JWT, incluyendo:

- Clave de firma.
- Issuer.
- Audience.

Utiliza una clave segura y mantenla fuera de los archivos versionados cuando corresponda.

### 4. Restaurar dependencias

Desde la carpeta que contiene `ProyectoFullStack.API.csproj`, ejecuta:

```bash
dotnet restore
```

### 5. Aplicar migraciones

Si la base de datos todavía no está actualizada, desde la Consola del Administrador de paquetes NuGet de Visual Studio puedes ejecutar:

```powershell
Update-Database
```

Verifica la cadena de conexión y el proyecto predeterminado antes de ejecutar migraciones.

### 6. Ejecutar la API

Desde la carpeta del proyecto de la API:

```bash
dotnet run
```

Abre la URL que aparezca en la consola. Si Swagger está habilitado para el entorno de ejecución, accede a la ruta `/swagger`.

---

## 🧪 Pruebas de la API

Los endpoints se prueban mediante Swagger.

Las pruebas realizadas incluyen:

- Consultas y operaciones CRUD de productos.
- Validaciones de datos.
- Registro de usuarios.
- Rechazo de correos electrónicos duplicados.
- Validación de credenciales en el login.
- Generación y validación de tokens JWT.
- Acceso a endpoints protegidos mediante autenticación.

Los endpoints y sus rutas exactas pueden consultarse en Swagger una vez ejecutada la API.



## 👨‍💻 Autor

**César Sánchez**

Estudiante de Ingeniería de Software, enfocado en el desarrollo backend con C#, .NET y SQL Server, con interés en construir aplicaciones Full Stack y fortalecer sus conocimientos en arquitectura de software y buenas prácticas de programación.

- **GitHub:** [@csanchezm21](https://github.com/csanchezm21)
- **Repositorio:** [ProyectoFullStack](https://github.com/csanchezm21/ProyectoFullStack)

---


