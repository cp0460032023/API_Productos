using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Productos.Entity;
using API_Productos.Repository;

namespace API_Productos.Controllers
{
    // Define la ruta base para este controlador como "api/productos"
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        // Repositorio para gestionar productos
        private readonly E_ProductoRepository _repository;

        // Constructor que inyecta el repositorio de productos
        public ProductosController(E_ProductoRepository repository)
        {
            _repository = repository;
        }

        // Endpoint GET para obtener todos los productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> FindAll()
        {
            return Ok(await _repository.FindAll());
        }

        // Endpoint GET para obtener un producto por su ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Productos?>> GetById(int id)
        {
            var producto = await _repository.GetById(id);

            // Si el producto no existe, devuelve un error 404 (Not Found)
            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // Endpoint POST para crear un nuevo producto
        [HttpPost]
        public async Task<ActionResult<Productos>> Create([FromBody] Productos producto)
        {
            // Verifica que el producto no sea nulo
            if (producto == null)
            {
                return BadRequest();
            }

            var createProduct = await _repository.Create(producto);

            // Devuelve una respuesta 201 (Created) con la URL del nuevo recurso creado
            return CreatedAtAction(nameof(GetById), new { id = createProduct.Id }, createProduct);
        }

        // Endpoint PUT para actualizar un producto existente
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] Productos productos)
        {
            await _repository.Update(id, productos);
            return Ok();
        }

        // Endpoint DELETE para eliminar un producto por su ID
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return Ok();
        }
    }
}



