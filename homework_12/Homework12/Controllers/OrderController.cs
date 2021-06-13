using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Homework12.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        private readonly OrderContext context;
        private OrderService orderService = new OrderService();

        public OrderController(OrderContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await context.Orders.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            List<Order> orders = orderService.SelectByOrderID(id);

            var order = await context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return orders;
        }

        //添加订单
        [HttpPost]
        public Order PostOrder2([FromBody] Order order)
        {
            Order order1 = new Order(order.OrderID, order.OrderDate, order.Customer);
            try
            {
                orderService.AddOrder(order1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return order1;
        }

    }

}
