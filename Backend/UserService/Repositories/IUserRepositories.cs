using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Repositories;

public interface IUserRepositories
{
    Task AddUserAsync(User user);
    Task<User> GetUserByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task SaveAsync();
    Task<User?> GetByAuth0IdAsync(string auth0Id);
}