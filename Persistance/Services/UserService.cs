﻿using Application.DTOs;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Repositories.UserRepo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistance.Services
{
    public class UserService : IUserService
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IMapper _mapper;

        public UserService(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository, IMapper mapper)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
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

        public async Task<List<UserDto>> SearchUsersByNameAsync(string name)
        {
            var users = await _userReadRepository.GetWhere(c => c.Name.Contains(name)).ToListAsync();
            if (users == null)
                return null;
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<bool> CreateUserAsync(CreateUserDto UserDto)
        {
            var user = _mapper.Map<User>(UserDto);
            var result = await _userWriteRepository.AddAsync(user);
            await _userWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateUserAsync(UpdateUserDto UserDto)
        {
            var user = await _userReadRepository.GetByIdAsync(UserDto.Id);
            if (user == null)
                return false;

            _mapper.Map(UserDto, user);
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
