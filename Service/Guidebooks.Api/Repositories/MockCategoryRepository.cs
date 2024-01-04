using System.Collections.Generic;
using System.Linq;
using Guidebooks.Api.Models;

namespace Guidebooks.Api.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;

        public MockCategoryRepository()
        {
            if (_categories == null)
            {
                InitializeDestinations();
            }
        }

        private void InitializeDestinations()
        {
            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Breakfast / Coffee", Description = "Breakfast restaurants and coffee shops", GuidebookId = 1 },
                new Category { Id = 2, Name = "Lunch / Dinner", Description = "Eateries serving both lunch and dinner", GuidebookId = 1 },
                new Category { Id = 3, Name = "Dinner", Description = "Eateries open during dinner hours only", GuidebookId = 1 },
                new Category { Id = 4, Name = "Cocktails", Description = "Bars and cocktail lounges serving no or almost no food", GuidebookId = 1 },

                new Category { Id = 5, Name = "Sandusky", Description = "Eateries in greater Sandusky area outside of downotwn", GuidebookId = 2 },
                new Category { Id = 6, Name = "Huron", Description = "Eateries in Huron", GuidebookId = 2 },
                new Category { Id = 7, Name = "Marblehead / Port Clinton", Description = "Eateries in Marblehead, Catawba, and Port Clinton areas", GuidebookId = 2 },
                new Category { Id = 8, Name = "Milan / Norwalk", Description = "Eateries in Milan and Norwalk", GuidebookId = 2 },

                new Category { Id = 9, Name = "Parks", Description = "Parks and waterfront walking areas", GuidebookId = 3 },
                new Category { Id = 10, Name = "Cruises", Description = "Cruise boats and ferries", GuidebookId = 3 },
                new Category { Id = 11, Name = "Game / Adventure Venues", Description = "Venues focused on games / activities", GuidebookId = 3 },
                new Category { Id = 12, Name = "Museums", Description = "Museums", GuidebookId = 3 },
                new Category { Id = 13, Name = "Art & Culture", Description = "Theaters, libraries, art galleries, etc.", GuidebookId = 3 },

                new Category { Id = 14, Name = "Sandusky", Description = "Entertainment venues in greater Sandusky area outside of downotwn", GuidebookId = 4 },
                new Category { Id = 15, Name = "Huron", Description = "Entertainment venues in Huron", GuidebookId = 4 },
                new Category { Id = 16, Name = "Marblehead / Port Clinton", Description = "Entertainment venues in Marblehead, Catawba, and Port Clinton areas", GuidebookId = 4 },
                new Category { Id = 17, Name = "Milan / Norwalk", Description = "Entertainment venues in Milan and Norwalk", GuidebookId = 4 },
            };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public IEnumerable<Category> GetCategoriesByGuidebookId(int guidebookId)
        {
            return _categories.Where(c => c.GuidebookId == guidebookId);
        }
    }
}