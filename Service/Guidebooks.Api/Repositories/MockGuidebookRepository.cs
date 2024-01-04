using System.Collections.Generic;
using System.Linq;
using Guidebooks.Api.Models;

namespace Guidebooks.Api.Repositories
{
    public class MockGuidebookRepository : IGuidebookRepository
    {
        private List<Guidebook> _guidebooks;

        public MockGuidebookRepository()
        {
            if (_guidebooks == null)
            {
                InitializeGuidebooks();
            }
        }

        private void InitializeGuidebooks()
        {
            _guidebooks = new List<Guidebook>
            {
                new Guidebook { Id = 1, Header="Foodie", Name = "Walking-Distance Foodie Guidebook", Description = "Eating and drinking within walking distance from downtown Sandusky", ImageUrl="/images/1.png" },
                new Guidebook { Id = 2, Header="Foodie", Name = "In-The-Vicinity Foodie Guidebook", Description = "Eating and drinking within 1/2 hour drive from downtown Sandusky", ImageUrl="/images/Area.png" },
                new Guidebook { Id = 3, Header="Entertainment", Name = "Walking-Distance Entertainment Guidebook", Description = "Things to do within walking distance from downtown Sandusky", ImageUrl="/images/3.png" },
                new Guidebook { Id = 4, Header="Entertainment", Name = "In-The-Vicinity Entertainment Guidebook", Description = "Things to do within 1/2 hour drive from downtown Sandusky", ImageUrl="/images/4.png" }
            };
        }

        public IEnumerable<Guidebook> GetAllGuidebooks()
        {
            return _guidebooks;
        }

        public Guidebook GetGuidebookById(int guidebookId)
        {
            return _guidebooks.FirstOrDefault(g => g.Id == guidebookId);
        }
    }
}