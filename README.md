# API NET CORE 5
## Proyecto Base
Proyecto base para implementar en cualquier aplicación. Incluye datos de usuario pre cargados al correr los migrations y aplicación.

## Especificaciones:
    - Asp Net Core 5
    - IdentityFramework
    - Swagger
    - Fluent Validator
    - Automapper
    - MediatR Pattern
    - CORS Arch
    . SQL Server
    - Redis Caching
    
## Docker Images
    - SQL Server Images
    - Redis Image

## Instalacion

### Docker
    - docker-compose up -d

### AppSettings.json
    - Modificar ambas cadenas de conexión SQL
    - Modificar conexión a redis
    
### Consola de Paquetes Nuget
    - En consola adminitración de paquetes nuget, seleccionar proyecto "Persistence"
    - Ejectuar el comando: add-migration MigracionInicial -Context ApplicationDbContext -o Migrations
    - Luego: update-database -Context ApplicationDbContext
    - Dentro de la misma consola, seleccionar el proyecto "Identity"
    - Ejectuar el comando: add-migration IdentityMigracionInicial -Context IdentityContext -o Migrations
