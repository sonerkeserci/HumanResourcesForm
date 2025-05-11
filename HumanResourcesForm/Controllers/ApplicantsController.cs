using Microsoft.AspNetCore.Mvc;
using HumanResourcesForm.Data;

namespace HumanResourcesForm.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly HRContext _context;
        public ApplicantsController(HRContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var applicants = _context.Applicants.ToList();
            return View(applicants);
        }
    }
}
