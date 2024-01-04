using System.Collections.Generic;
using System.Linq;
using Guidebooks.Api.Models;
using Guidebooks.Api.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Guidebooks.Api.ViewModels
{
    public class IndexModel : PageModel
    {
        private readonly IGuidebookRepository _guidebookRepository;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel
        (
            IGuidebookRepository guidebookRepository,
            ILogger<IndexModel> logger
        )
        {
            _guidebookRepository = guidebookRepository;
            _logger = logger;
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public List<Guidebook> Guidebooks { get; set; }

        public void OnGet
        (
        )
        {
            Guidebooks = _guidebookRepository.GetAllGuidebooks().OrderBy(g => g.Id).ToList();
            Title = "Guidebook Overview";
            Message = "Welcome to my Vacationland area Guidebooks!";
        }
    }
}
