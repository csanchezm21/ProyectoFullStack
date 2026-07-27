# 🚀 Proyecto Full Stack | Gestión de Productos

## 📖 Descripción

Proyecto Full Stack desarrollado con el objetivo de construir una aplicación web moderna siguiendo buenas prácticas de desarrollo Backend y Frontend.

Actualmente se encuentra en desarrollo e implementa una API REST con ASP.NET Core, Entity Framework Core y SQL Server. En las siguientes etapas se incorporará Angular para el consumo de la API y autenticación mediante JWT.

---

# ✨ Objetivos

- Desarrollar una API REST profesional.
- Implementar arquitectura por capas.
- Aplicar Inyección de Dependencias.
- Utilizar Entity Framework Core como ORM.
- Gestionar datos con SQL Server.
- Construir un frontend en Angular.
- Implementar autenticación con JWT.
- Publicar el proyecto como parte de mi portafolio profesional.

---

# 🛠 Tecnologías

## Backend

- ASP.NET Core 8 Web API
- C#
- Entity Framework Core 8
- Swagger / OpenAPI

## Base de datos

- SQL Server Express
- SQL Server Management Studio (SSMS)

## Frontend (Próximamente)

- Angular
- TypeScript
- HTML5
- CSS3

## Herramientas

- Visual Studio 2022
- Visual Studio Code
- Git
- GitHub

---

# 🏗 Arquitectura

El proyecto implementa una arquitectura por capas para mantener una correcta separación de responsabilidades.

```
# 📂 Estructura del proyecto

```

ProyectoFullStack

├── Backend
│
│   └── ProyectoFullStack.API
│
│       ├── Controllers
│       ├── Data
│       ├── Interfaces
│       ├── Models
│       ├── Services
│       ├── Program.cs
│       └── appsettings.json
│
├── BaseDatos
│
└── Frontend

```


# 🗄 Base de datos

Motor utilizado:

- SQL Server Express

Base de datos:

```

ProyectoFullStackDB

```

Tabla principal:

```

Productos

```

| Campo | Tipo |
|--------|------|
| Id | INT IDENTITY |
| Nombre | NVARCHAR(100) |
| Precio | DECIMAL(18,2) |
| Stock | INT |

---

# ✅ Funcionalidades implementadas

- API REST con ASP.NET Core.
- Arquitectura por capas.
- Inyección de Dependencias.
- Entity Framework Core.
- Conexión con SQL Server.
- Consulta de productos desde base de datos.
- Documentación automática con Swagger.

---
# ▶ Ejecución del proyecto

Clonar el repositorio

```bash
git clone https://github.com/csanchezm21/ProyectoFullStack.git
```

Abrir la solución con Visual Studio 2022.

Configurar la cadena de conexión en:

```

appsettings.json

```

Ejecutar la aplicación.

Swagger estará disponible en:

```

https://localhost:7281/swagger

```

---

# 👨‍💻 Autor

## César Sánchez

Estudiante de Ingeniería de Software y desarrollador Backend en formación.

### Tecnologías

- ASP.NET Core
- C#
- SQL Server
- Entity Framework Core
- Angular
- Git
- GitHub

GitHub:

https://github.com/csanchezm21

---

# 📌 Estado del proyecto

🟢 En desarrollo