using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Presentation.Controllers;
[Route("api/orders/{orderId}/orderitems")]
[ApiController]
public class OrderItemsController : ControllerBase
{
    private readonly IServiceManager _service;

    public OrderItemsController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrderItems(int orderId)
    {
        var orderItems = await _service.OrderItemService.GetOrderItemsAsync(orderId, trackChanges: false);

        return Ok(orderItems);
    }

    [HttpGet("{id}", Name = "GetOrderItem")]
    public async Task<IActionResult> GetOrderItemById(int orderId, int id)
    {
        var orderItem = await _service.OrderItemService.GetOrderItemAsync(orderId, id, trackChanges: false);

        return Ok(orderItem);
    }

    [HttpPost]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> CreateOrderItem(int orderId, [FromBody] OrderItemForCreationDto orderItem)
    {
        var orderItemToReturn = await _service.OrderItemService.CreateOrderItemAsync(orderId, orderItem, trackChanges: false);

        return CreatedAtRoute("GetOrderItem", new { orderId, id = orderItemToReturn.Id }, orderItemToReturn);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteOrderItem(int orderId, int id)
    {
        await _service.OrderItemService.DeleteOrderItemAsync(orderId, id, trackChanges: false);

        return NoContent();
    }

    [HttpPut("{id:int}")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> UpdateOrderItem(int orderId, int id, [FromBody] OrderItemForUpdateDto orderItem)
    {
        await _service.OrderItemService.UpdateOrderItemAsync(orderId, id, orderItem, orderTrackChanges: false, orderItemTrackChanges: true);

        return NoContent();
    }
}
