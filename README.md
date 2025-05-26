# Catálogo Service

Este servicio proporciona endpoints para consultar **lugares**, **rutas** y **horarios** disponibles en el sistema de reservas de autobuses. Forma parte de una arquitectura SOA y expone su funcionalidad a través de una API REST.

## 🚀 Tecnologías
- .NET 8
- C#
- MySQL
- Entity Framework Core
- Swagger (documentación de API)
- Clean Architecture
- Adapters
- Abstract Factory

## 📂 Estructura
├── Controllers/
├── Domain/
├── Application/
├── Infrastructure/
└── Program.cs


## 🔌 Endpoints

| Método | Ruta                  | Descripción                          |
|--------|------------------------|--------------------------------------|
| GET    | `/api/lugares`        | Lista todos los lugares              |
| GET    | `/api/rutas`          | Lista todas las rutas activas        |
| GET    | `/api/rutas/buscar`   | Busca rutas entre origen y destino   |
| GET    | `/api/horarios`       | Lista todos los horarios             |

## ⚙️ Configuración
- Asegúrate de tener MySQL corriendo y la base de datos `sistema_reservas` creada.
- Agrega la cadena de conexión en `appsettings.json`.

```json
"ConnectionStrings": {
  "MySql": "server=localhost;database=sistema_reservas;user=root;password=tu_clave"
}

dotnet build
dotnet run

http://localhost:{puerto}/swagger

