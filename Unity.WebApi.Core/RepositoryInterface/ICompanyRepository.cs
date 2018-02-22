using System.Collections.Generic;
using Unity.WebApi.Core.Models;

namespace Unity.WebApi.Core.RepositoryInterface
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
        Company Add(Company item);
        bool Update(Company item);
        bool Delete(int id);
    }
}
