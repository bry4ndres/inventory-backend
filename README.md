# 📦 Inventory Backend - ProductService (.NET 8)

## ✅ Requisitos
- [.NET SDK 8.0]
- [SQL Server]
- Visual Studio 2022
- Git
- 
## ⚙️ Ejecución del backend
### 1. Creación de las BD y Tablas
- ejecuta el script que se encuentra en la raíz del proyecto "BDScript"
- Deben crearce dos BD una llamada  ProductDB y TransactionDB
- Debe crearce una tabla en cada una de las BD (Products y Transactions) respectivamente
  
### 2. Configura la cadena de conexión
- Edita el nombre del server en el archivo appsettings.json ubicado en ProductService/ProductService.API/appsettings.json.
- En "DefaultConnection" modificar "Server=ASUS-ROG\\SQLEXPRESS01; por el nombre de tu instancia de SQL Server, dejar el nombre de la DB igual.

- Edita el nombre del server en el archivo appsettings.json ubicado en TransactionService/TransactionService.API/appsettings.json.
- En "DefaultConnection" modificar "Server=ASUS-ROG\\SQLEXPRESS01; por el nombre de tu instancia de SQL Server, dejar el nombre de la DB igual.
- Modificar el "ProductService" por la dirección en la que se esta ejecutando el microservicio de ProductService

### 3.Levanta el proyecto
- Debes ejecutar el proyecto con el inicio multiple de proyectos
- En el boton de Iniciar proyecto - Start, ve a "Configure Startup Projects"
- Selecciona Multiple startup
- en la opción action de los proyectos ProductService.API y TransactionService.API pon en Start

- Ahora ya puedes dar a iniciar los proyectos.
- Podras ver las APIs con sus URLs las cuales te pueden servir para configurar el ProductService y los endpoints en el proyecto de Angular
