
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Domain.Interfaces;

public interface IUserRepository
{
    public Task AddAsync(User user);
    Task<IEnumerable<User>> GetAllAsync();
}
