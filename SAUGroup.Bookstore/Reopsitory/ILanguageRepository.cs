using SAUGroup.Bookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAUGroup.Bookstore.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}