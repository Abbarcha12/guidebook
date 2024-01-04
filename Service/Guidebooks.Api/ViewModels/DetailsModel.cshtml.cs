using System.Collections.Generic;
using System.Linq;
using Guidebooks.Api.Models;
using Guidebooks.Api.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Guidebooks.Api.ViewModels
{
    public class DetailsModel : PageModel
    {
        private readonly IGuidebookRepository _guidebookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDestinationRepository _destinationRepository;
        private readonly ILogger<DetailsModel> _logger;

        public DetailsModel
        (
            IGuidebookRepository guidebookRepository,
            ICategoryRepository categoryRepository,
            IDestinationRepository destinationRepository,
            ILogger<DetailsModel> logger
        )
        {
            _guidebookRepository = guidebookRepository;
            _categoryRepository = categoryRepository;
            _destinationRepository = destinationRepository;
            _logger = logger;
        }

        public string GuidebookName { get; set; }
        public string GuidebookDescription { get; set; }
        public List<Category> Categories { get; set; }
        public List<Destination> Destinations { get; set; }

        public void OnGet
        (
            int id
        )
        {
            if (id > 0)
            {
                GuidebookName = _guidebookRepository.GetGuidebookById(id).Name;
                GuidebookDescription = _guidebookRepository.GetGuidebookById(id).Description;

                Categories = _categoryRepository.GetCategoriesByGuidebookId(id).OrderBy(c => c.Id).ToList();
                Destinations = _destinationRepository.GetDestinationsByGuidebookId(id).OrderBy(d => d.Id).ToList();
            }
        }
    }
}
