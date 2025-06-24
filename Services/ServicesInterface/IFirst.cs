using Back_End.Models;

namespace Back_End.Services.ServicesInterface;

public interface IFirst
{

    public Task<List<Manager>> getAllManagers();
}