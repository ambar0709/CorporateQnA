using CorporateQnA.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Services
{
    public interface ICategoryService
    {
        public Task AddCategory(DbCategory category);
        public Task<List<DbCategory>> GetAllCategories(); 
    }
}
