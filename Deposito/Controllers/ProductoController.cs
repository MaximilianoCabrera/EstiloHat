using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Deposito.Models;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Deposito.Controllers
{
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private readonly ProductoContext _context;

        public ProductoController(ProductoContext context)
        {
            _context = context;

            if (_context.Productos.Count() == 0)
            {
                _context.Productos.Add(new Producto { nombre = "Martillo",
                                                      descripcion = "Sirve para clavar" });
                _context.SaveChanges();
            }
        }
    }
}
