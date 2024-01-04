using System.Collections.Generic;
using Guidebooks.Api.Models;

namespace Guidebooks.Api.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
        IEnumerable<Category> GetCategoriesByGuidebookId(int guidebookId);
    }
}
