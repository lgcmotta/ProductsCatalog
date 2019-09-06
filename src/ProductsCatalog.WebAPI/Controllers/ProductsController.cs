using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsCatalog.WebAPI.Core.Domain;
using ProductsCatalog.WebAPI.Infrastructure.EntityFramework.Context;

namespace ProductsCatalog.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext _context;

        public ProductsController(ProductsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var products = await _context.Products.ToListAsync();

                return Ok(products);
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

                return Ok(product);
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            try
            {
                await _context.AddAsync(product);

                var saved = await _context.SaveChangesAsync();

                if(saved > 0)
                    return CreatedAtAction(nameof(GetProduct), new {id = product.Id}, product);

                return BadRequest();
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Product product)
        {
            try
            {
                if (id != product.Id)
                    return BadRequest();

                _context.Entry(product).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}