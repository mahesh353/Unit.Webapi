using System.Collections.Generic;
using System.Web.Http;
using Unity.WebApi.Core.Models;
using Unity.WebApi.Core.RepositoryInterface;

namespace Unity.WebApi.Controllers
{
    public class CompanyController : ApiController
    {

        private ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public IEnumerable<Company> Get()
        {
            return _companyRepository.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
