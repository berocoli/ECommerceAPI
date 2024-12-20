using System.Text.RegularExpressions;
using Application.DTOs;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;

        public UserService(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository, ICartService cartService, IMapper mapper)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
            _cartService = cartService;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _userReadRepository.GetAll().ToListAsync();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> GetUserByIdAsync(string id)
        {
            var user = await _userReadRepository.GetByIdAsync(id);
            if (user == null)
                return null;
            return _mapper.Map<UserDto>(user);
        }

        public async Task<List<UserDto>> SearchUsersByNameAsync(string name, string? surname)
        {
            var query = _userReadRepository.GetWhere(u => u.Name.Contains(name));

            // Only filter by surname if it's provided (not null or empty)
            if (!string.IsNullOrEmpty(surname))
            {
                query = query.Where(u => u.Surname.Contains(surname));
            }

            var users = await query.ToListAsync();

            if (users == null || users.Count == 0)
            {
                return new List<UserDto>(); 
            }

            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<bool> CreateUserAsync(string name, string surname, string email, string password, string phoneNumber, string country)
        {
            // Validations
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Name, email, and password cannot be null or empty.");

            if (name.Length < 2 || name.Length > 50)
                throw new FormatException("Name must be between 2 and 50 characters long.");

            if (!string.IsNullOrEmpty(surname) && (surname.Length < 2 || surname.Length > 50))
                throw new FormatException("Surname must be between 2 and 50 characters long.");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new FormatException("Invalid email format.");

            var existingUser = await _userReadRepository.GetUserByEmailAsync(email);
            if (existingUser != null)
                throw new ArgumentException("An account with this email already exists.");

            if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"[0-9]") || !Regex.IsMatch(password, @"[\W_]"))
                throw new FormatException("Password must be at least 8 characters long and include uppercase, lowercase, numeric, and special characters.");

            if (string.IsNullOrWhiteSpace(phoneNumber) || !Regex.IsMatch(phoneNumber, @"^\+?[0-9]{10,15}$"))
                throw new FormatException("Phone number must be between 10 and 15 digits and may include an optional '+' for the country code.");

            if (!Enum.TryParse<UserCountry>(country, true, out var parsedCountry))
                throw new FormatException($"Invalid country value. Accepted values: {string.Join(", ", Enum.GetNames(typeof(UserCountry)))}");

            var paymentCurrency = parsedCountry switch
            {
                UserCountry.Turkey => PaymentCurrency.TRY,
                UserCountry.America => PaymentCurrency.USD,
                UserCountry.Europe => PaymentCurrency.EUR,
                UserCountry.Switzerland => PaymentCurrency.CHF,
                UserCountry.Japan => PaymentCurrency.JPY,
                UserCountry.Qatar => PaymentCurrency.QAR,
                _ => PaymentCurrency.USD // Default to USD 
            };

            // Create the user DTO
            var createUserDto = new CreateUserDto
            {
                Name = name,
                Surname = surname,
                EMail = email,
                Password = password, 
                PhoneNumber = phoneNumber,
                UserCountry = parsedCountry,
                PaymentCurrency = paymentCurrency 
            };

            var user = _mapper.Map<User>(createUserDto);
            var result = await _userWriteRepository.AddAsync(user);
            await _cartService.CreateCartAsync(user.Id.ToString());

            await _userWriteRepository.SaveAsync();

            return result;
        }

        public async Task<bool> CreateAdminUserAsync(string name, string surname, string email, string password, bool role)
        {
            var createAdminDto = new CreateAdminDto
            {
                Name = name,
                Surname = surname,
                EMail = email,
                Password = password,
                Role = role
            };

            var admin = _mapper.Map<User>(createAdminDto);
            var result = await _userWriteRepository.AddAsync(admin);
            await _userWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateUserAsync(string id, string name, string surname, string email, string password, bool role)
        {
            var user = await _userReadRepository.GetByIdAsync(id);
            if (user == null)
                return false;

            var updateUserDto = new UpdateUserDto
            {
                Id = id,
                Name = name,
                Surname = surname,
                EMail = email,
                Password = password,
                Role = role
            };

            _mapper.Map(updateUserDto, user);
            var result = _userWriteRepository.Update(user);
            await _userWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            var result = await _userWriteRepository.RemoveAsync(id);
            await _userWriteRepository.SaveAsync();
            return result;
        }
    }
}