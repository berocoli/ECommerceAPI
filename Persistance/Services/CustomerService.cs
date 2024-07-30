using Application.DTOs;
using Application.Repositories;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, IMapper mapper)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomerDto>> GetAllCustomersAsync()
        {
            var customers = await _customerReadRepository.GetAll().ToListAsync();
            return _mapper.Map<List<CustomerDto>>(customers);
        }

        public async Task<CustomerDto> GetCustomerByIdAsync(string id)
        {
            var customer = await _customerReadRepository.GetByIdAsync(id);
            if (customer == null)
                return null;
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<List<CustomerDto>> SearchCustomersByNameAsync(string name)
        {
            var customers = await _customerReadRepository.GetWhere(c => c.Name.Contains(name)).ToListAsync();
            return _mapper.Map<List<CustomerDto>>(customers);
        }

        public async Task<bool> CreateCustomerAsync(CreateCustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            var result = await _customerWriteRepository.AddAsync(customer);
            await _customerWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateCustomerAsync(UpdateCustomerDto customerDto)
        {
            var customer = await _customerReadRepository.GetByIdAsync(customerDto.Id);
            if (customer == null)
                return false;

            _mapper.Map(customerDto, customer);
            var result = _customerWriteRepository.Update(customer);
            await _customerWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteCustomerAsync(string id)
        {
            var result = await _customerWriteRepository.RemoveAsync(id);
            await _customerWriteRepository.SaveAsync();
            return result;
        }
    }
}
