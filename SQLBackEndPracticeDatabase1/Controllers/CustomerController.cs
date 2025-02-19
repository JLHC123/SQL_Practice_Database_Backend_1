using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLBackEndPracticeDatabase1.Data;
using SQLBackEndPracticeDatabase1.DTO;

namespace SQLBackEndPracticeDatabase1.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        private readonly ILogger<CustomerController> _logger;
        public CustomerController(AppDbContext context, ILogger<CustomerController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetCustomer()
        {
            var customers = await _context.Customers
                .Select(c => new CustomerDTO
                {
                    CustomerId = c.CustomerId,
                    CustomerFirstName = c.CustomerFirstName,
                    CustomerLastName = c.CustomerLastName,
                })
                .ToListAsync();
            return Ok(customers);
        }
    }
}
