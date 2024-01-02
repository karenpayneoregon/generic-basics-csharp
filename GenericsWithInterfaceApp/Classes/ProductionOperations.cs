using CoreLibrary.Interfaces;
using GenericsWithInterfaceApp.Models;

namespace GenericsWithInterfaceApp.Classes;

#pragma warning disable CS8618
public class ProductionOperations : IOperations<Product>
{
    public IEnumerable<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetByIdWithIncludes(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdWithIncludesAsync(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(in Product sender)
    {
        throw new NotImplementedException();
    }

    public void Update(in Product sender)
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