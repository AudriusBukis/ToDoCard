using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebASPNET_API.Context;
using WebASPNET_API.Models;
using WebASPNET_API.Services;

namespace WebASPNET_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(ApplicationDbContext context, IMapper mapper, ILogger<UserRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }
        public User AddNewUser(UserDto userDto)
        {
            try
            {
                _logger.LogInformation($"Adding {userDto}");
                var newUser = _mapper.MapUserDtoWithUser(userDto);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return newUser;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default;
            }
        }
        public User UpdateUser(UserDto userDto, int id)
        {
            try
            {
                _logger.LogInformation($"Updating\n {userDto}");
                var userToUpdate = _context.Users.Single(x => x.Id == id);
                userToUpdate.Name = userDto.Name;
                userToUpdate.LastName = userDto.LastName;
                userToUpdate.Email = userDto.Email;
                _context.SaveChanges();
                return userToUpdate;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default;
            }
        }
        public User DeleteUser(int id)
        {
            try
            {
                var userToDelate = _context.Users.Single(x => x.Id == id);
                _logger.LogInformation($"Deleting\n {userToDelate}");
                _context.Users.Remove(userToDelate);
                _context.SaveChanges();
                return userToDelate;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default;
            }
            
        }
    }
}
