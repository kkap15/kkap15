using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Models;

namespace OrderService.Repositories;

public class OrderRepositories(OrderDbContext context) : IOrderRepositories
{
    public async Task AddOrderAsync(Order order)
    {
        await context.Orders.AddAsync(order);
    }

    public async Task<Order?> GetOrderByIdAsync(Guid id)
    {
        return await context.Orders.FirstOrDefaultAsync(o => o.Id == id);
    }

    public async Task<IEnumerable<Order>> GetAllOrdersAsync()
    {
        return await context.Orders.ToListAsync();
    }

    public async Task SaveAsync()
    {
        await context.SaveChangesAsync();
    }
    
    public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(Guid userId)
    {
        return await context.Orders.Where(o => o.UserId == userId).ToListAsync();
    }
}