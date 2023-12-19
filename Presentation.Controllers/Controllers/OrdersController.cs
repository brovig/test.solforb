using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System.Text.Json;

namespace Presentation.Controllers;

[Route("api/orders")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IServiceManager _service;

    public OrdersController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders([FromQuery] OrderParameters filterParameters)
    {
        var pagedOrders = await _service.OrderService.GetOrdersAsync(filterParameters, trackChanges: false);
        Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedOrders.metaData));

        return Ok(pagedOrders.orders);
    }

    [HttpGet("{id:int}", Name = "OrderById")]
    public async Task<IActionResult> GetOrder(int id)
    {
        var order = await _service.OrderService.GetOrderAsync(id, trackChanges: false);

        return Ok(order);
    }

    [HttpPost]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> CreateOrder([FromBody] OrderForCreationDto order)
    {
        var createdOrder = await _service.OrderService.CreateOrderAsync(order);

        return CreatedAtRoute("OrderById", new { id = createdOrder.Id }, createdOrder);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteOrder(int id)
    {
        await _service.OrderService.DeleteOrderAsync(id, trackChanges: false);

        return NoContent();
    }

    [HttpPut("{id:int}")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> UpdateOrder(int id, [FromBody] OrderForUpdateDto order)
    {
        await _service.OrderService.UpdateOrderAsync(id, order, trackChanges: true);

        return NoContent();
    }
}
