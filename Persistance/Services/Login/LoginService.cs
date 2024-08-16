﻿using System;
using System.Threading.Tasks;
using Infrastructure.Operations;
using AutoMapper;
using Application.DTOs;
using Application.Services;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Application.Services.TokenServices;

namespace Persistence.Services.Login
{
    public class LoginService : ILoginService
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;

        public LoginService(ICustomerReadRepository customerReadRepository, IMapper mapper, ITokenService tokenService)
        {
            _customerReadRepository = customerReadRepository;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        public async Task<CustomerDto> LoginHandler(string email, string password)
        {
            // Retrieve the user by email
            var customer = await _customerReadRepository.GetWhere(p => p.Email == email).FirstOrDefaultAsync();
            if (customer == null)
            {
                // Handle user not found (throw an exception or return a specific result)
                return null; // Replace this with proper error handling
            }

            // Verify the password
            bool isPasswordValid = PasswordHasher.VerifyPassword(password, customer.Password);
            if (!isPasswordValid)
            {
                // Handle invalid password (throw an exception or return a specific result)
                return null; // Replace this with proper error handling
            }

            // If the login is successful, map the Customer to CustomerDto
            var customerDto = _mapper.Map<CustomerDto>(customer);

            _tokenService.TokenGenerator(customer.Email);
            return customerDto;
        }
    }
}
