using Back_End.Data;
using Back_End.Models;
using Back_End.Services.ServicesInterface;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Services;

public class FirstService : IFirst
{
    private readonly PawPalsDbContext _context;

    public FirstService(PawPalsDbContext context)
    {
        _context = context;
    }
    
   
    public async Task<List<Manager>> getAllManagers()
    {
        return await _context.Managers.ToListAsync();
    }
}