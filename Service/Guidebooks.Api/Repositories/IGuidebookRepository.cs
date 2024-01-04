using System.Collections.Generic;
using Guidebooks.Api.Models;

namespace Guidebooks.Api.Repositories
{
    public interface IGuidebookRepository
    {
        IEnumerable<Guidebook> GetAllGuidebooks();
        Guidebook GetGuidebookById(int guidebookId);
    }
}
