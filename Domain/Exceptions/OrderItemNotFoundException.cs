using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Exceptions;
public sealed class OrderItemNotFoundException : NotFoundException
{
    public OrderItemNotFoundException(int id) : base($"Order item with id: {id} doesn't exist in the database.") { }
}
