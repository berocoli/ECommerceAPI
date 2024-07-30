using System;
using Application.DTOs;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Services
{
    public class OrderService : IOrderService
    {
        public readonly IOrderReadRepository _orderReadRepository;
        public readonly IOrderWriteRepository _orderWriteRepository;
        public readonly IMapper _mapper;

        public OrderService(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IMapper mapper)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateOrderAsync(CreateOrderDto createOrderDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOrderAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDto>> GetAllOrdersAsync()
        {
            var orders = await _orderReadRepository.GetAll().ToListAsync();
            return _mapper.Map<List<OrderDto>>(order)
        }

        public Task<OrderDto> GetOrderByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderAsync(UpdateOrderDto updateOrderDto)
        {
            throw new NotImplementedException();
        }
    }
}

