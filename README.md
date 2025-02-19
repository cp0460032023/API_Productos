# API_Productos
# API de Productos

## Descripción
Esta API permite la gestión de productos mediante operaciones CRUD, utilizando .NET 8 y SQL Server. Implementa el patrón Repository y proporciona documentación con Swagger.

## Entorno de Desarrollo
- **Visual Studio 2022** o superior
- **.NET 8** o superior
- **SQL Server**

## Especificaciones de la API
La API maneja una entidad llamada **Producto**, que contiene los siguientes campos:

- **Id** (*int*) → Clave primaria, autoincremental.
- **Nombre** (*string*) → Obligatorio, máximo 100 caracteres.
- **Precio** (*decimal*) → Obligatorio, mayor a 0.
- **Stock** (*int*) → Obligatorio, mínimo 0.

## Endpoints

### Obtener todos los productos
```http
GET /api/productos
```
**Descripción:** Devuelve la lista de productos.

### Obtener un producto por ID
```http
GET /api/productos/{id}
```
**Descripción:** Devuelve un producto específico.

### Agregar un nuevo producto
```http
POST /api/productos
```
**Descripción:** Crea un nuevo producto en la base de datos.

### Modificar un producto existente
```http
PUT /api/productos/{id}
```
**Descripción:** Modifica los datos de un producto existente.

### Eliminar un producto
```http
DELETE /api/productos/{id}
```
**Descripción:** Elimina un producto de la base de datos.

## Base de Datos
Se usa **Entity Framework Core** junto con **SQL Server** para la persistencia de datos.

## Buenas Prácticas Implementadas
- Uso del **patrón Repository** para separar la lógica de acceso a datos.
- Manejo de **excepciones** con respuestas HTTP adecuadas.
- Documentación de la API con **Swagger** para facilitar su uso.

## Instalación y Configuración
1. Clona el repositorio
   ```
2. Configura la conexión a la base de datos en `appsettings.json`.
3. Ejecuta las migraciones:
   ```bash
   dotnet ef database update
   ```
4. Compila y ejecuta la API:
   ```bash
   dotnet run
   ```

## Autor
Desarrollado por Xiomara Abigail Cisneros Peña

