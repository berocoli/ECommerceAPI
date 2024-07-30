using Application.DTOs;

namespace Application.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerDto>> GetAllCustomersAsync();
        Task<CustomerDto> GetCustomerByIdAsync(string id);
        Task<List<CustomerDto>> SearchCustomersByNameAsync(string name);
        Task<bool> CreateCustomerAsync(CreateCustomerDto customerDto);
        Task<bool> UpdateCustomerAsync(UpdateCustomerDto customerDto);
        Task<bool> DeleteCustomerAsync(string id);
    }
}
