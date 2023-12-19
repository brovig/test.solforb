using AutoMapper;
using Domain.Entities.Models;
using Shared.DataTransferObjects;

namespace OrdersApp;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderItemDto>();
        CreateMap<Provider, ProviderDto>();

        CreateMap<OrderForCreationDto, Order>();
        CreateMap<OrderItemForCreationDto, OrderItem>();

        CreateMap<OrderItemForUpdateDto, OrderItem>();
        CreateMap<OrderItemForUpdateDto, OrderItemForCreationDto>();
        CreateMap<OrderForUpdateDto, Order>()
            .ForMember(o => o.Items, opt => opt.Ignore());
    }    
}
