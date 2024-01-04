using System.Collections.Generic;
using Guidebooks.Api.Models;

namespace Guidebooks.Api.Repositories
{
    public interface IDestinationRepository
    {
        IEnumerable<Destination> GetAllDestinations();
        IEnumerable<Destination> GetDestinationsByGuidebookId(int guidebookId);
        Destination GetDestinationById(int destinationId);
    }
}
