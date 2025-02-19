using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLBackEndPracticeDatabase1.Data;
using SQLBackEndPracticeDatabase1.DTO;

namespace SQLBackEndPracticeDatabase1.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<OrderController> _logger;
        public OrderController(AppDbContext context, ILogger<OrderController> logger) 
        {
            _context = context;
            _logger = logger;
        }

        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders()
        {
            var orders = await _context.Orders
                .Select(o => new OrderDTO
                {
                    OrderId = o.OrderId,
                    CustomerId = o.CustomerId,
                    OrderDate = o.OrderDate,
                })
                .ToListAsync();
            return Ok(orders);
        }
    }
}
