namespace Domain.Entities.Exceptions;
public sealed class ProviderNotFoundException : NotFoundException
{
    public ProviderNotFoundException(int id) : base($"The provider with id: {id} doesn't exist in the database.") { }
}
