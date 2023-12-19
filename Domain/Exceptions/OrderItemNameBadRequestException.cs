using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Exceptions;
public sealed class OrderItemNameBadRequestException : BadRequestException
{
    public OrderItemNameBadRequestException(string orderNumber) 
        : base($"Item's name can't be equal to order's number: {orderNumber}.") { }
}
