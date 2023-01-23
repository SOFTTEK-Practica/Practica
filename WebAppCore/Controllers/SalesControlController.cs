using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore.DatabaseContext;
using WebAppCore.Model;

namespace WebAppCore.Controllers
{
    [ApiVersion("1.0")]
    [Route("/api/salescontrol")]
    [ApiController]
    public class SalesControlController : ControllerBase
    {
        private readonly MyContext _context;
        public SalesControlController(MyContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSalesControl()
        {

            IQueryable<SalesControl> salesControl = _context.SalesControl;


            return Ok(await salesControl.ToArrayAsync());
        }
        [HttpGet]
        [Route("sellerunit")]

        public async Task<IActionResult> GetAllSalesControlSeller()
        {

            IQueryable<SalesControl> salesControl = _context.SalesControl;
            var listSeller = salesControl
             .GroupBy(m => m.seller)
             .Select(m => new {
                 Seller = m.Key,
                 Quantity = m.Sum(x => x.Quantity)
             });
            return Ok(await listSeller.ToArrayAsync());
        }

        [HttpGet]
        [Authorize]
        [Route("productunit")]
        public async Task<IActionResult> GetAllSalesControlProduct()
        {

            IQueryable<SalesControl> salesControl = _context.SalesControl;
            var listSeller = salesControl
             .GroupBy(m => m.Product)
             .Select(m => new {
                 Product = m.Key,
                 Quantity = m.Sum(x => x.Quantity)
             });
            return Ok(await listSeller.ToArrayAsync());
        }

        [HttpGet]
        [Authorize]
        [Route("customerunit")]
        public async Task<IActionResult> GetAllSalesControlPCustomer()
        {

            IQueryable<SalesControl> salesControl = _context.SalesControl;
            var listSeller = salesControl
             .GroupBy(m => m.Customer)
             .Select(m => new {
                 Customer = m.Key,
                 Quantity = m.Sum(x => x.Quantity)
             });
            return Ok(await listSeller.ToArrayAsync());
        }
        [HttpPost]
        public async Task<ActionResult<SalesControl>> CreateSalesControl([FromBody] SalesControl salesControl)
        {
            _context.SalesControl.Add(salesControl);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetAllSalesControl",
                new { id = salesControl.Id },
                salesControl
            );
        }
    }
}
