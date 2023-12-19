namespace Domain.Entities.Exceptions;
public sealed class OrderNotFoundException : NotFoundException
{
    public OrderNotFoundException(int id) : base($"The order with id: {id} doesn't exist in the database.") { }
}
