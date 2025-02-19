using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLBackEndPracticeDatabase1.Data;
using SQLBackEndPracticeDatabase1.DTO;

namespace SQLBackEndPracticeDatabase1.Controllers
{
    [Route("api/customeraddressess")]
    [ApiController]
    public class CustomerAddressController : ControllerBase
    {
        private readonly DbContext _context;
        private readonly ILogger<CustomerAddressController> _logger;

        public CustomerAddressController(DbContext context, ILogger<CustomerAddressController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerAddressDTO>>> GetCustomerAdressess()
        {
            var customeraddressess = await _context.CustomerAddresses
                .Select(a => new CustomerAddressDTO
                {
                    CustomerAddresssId = a.CustomerAddressId,
                    CustomerId = a.CustomerId,
                    Street1 = a.Street1,
                    Street2 = a.Street2,
                    City = a.City,
                    States = a.States,
                    Zip = a.Zip,
                })
                .ToListAsync();
            return Ok(customeraddressess);
        }
    }
}
