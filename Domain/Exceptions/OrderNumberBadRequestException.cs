using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Exceptions;
public sealed class OrderNumberBadRequestException : BadRequestException
{
    public OrderNumberBadRequestException(string orderNumber, int providerId) 
        : base($"Provider with id: {providerId} already has an order with number {orderNumber}.") { }
}
