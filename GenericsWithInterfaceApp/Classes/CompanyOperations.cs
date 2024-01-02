using CoreLibrary.Interfaces;
using GenericsWithInterfaceApp.Models;

namespace GenericsWithInterfaceApp.Classes;

#pragma warning disable CS8618
public class CompanyOperations : IOperations<Company>
{
    public IEnumerable<Company> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Company>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Company GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Company GetByIdWithIncludes(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Company> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Company> GetByIdWithIncludesAsync(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(in Company sender)
    {
        throw new NotImplementedException();
    }

    public void Update(in Company sender)
    {
        throw new NotImplementedException();
    }

    public int Save()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }
}